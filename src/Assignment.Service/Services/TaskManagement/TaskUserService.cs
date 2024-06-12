using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Assignment.Api.Interfaces;
using Assignment.Api.Interfaces.TaskManagement;
using Assignment.Api.Models;
using Assignment.Core.Models.TaskManagement;
using Assignment.Service.Model;
using Jose;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace Assignment.Service.Services.TaskUserServices
{
    public class TaskUserService
    {
        private readonly IDBTaskUserRepository _taskUserRepo;
        private readonly UserService _userservice;

        public TaskUserService(IDBTaskUserRepository taskUserRepo, UserService userService)
        {
            _taskUserRepo = taskUserRepo;
            _userservice = userService;
        }

        public async Task<TaskUsers> SignUpAsync(TaskUserSignupRQ taskUserSignupRQ)
        {
            var userInfo = await _taskUserRepo.GetUserByUsernameAsync(taskUserSignupRQ.Username);
            if (userInfo != null || !_userservice.IsPasswordValid(taskUserSignupRQ.Password))
            {
                throw new ArgumentException("Invalid signup request");
            }

            TaskUsers modelRQ = new TaskUsers()
            {
                Username = taskUserSignupRQ.Username,
                PasswordHash = taskUserSignupRQ.Password,
                Role = taskUserSignupRQ.IsAdministrator ? "Administrator" : "CommonUser",
                Email = taskUserSignupRQ.Email
            };

            return await _taskUserRepo.CreateUserAsync(modelRQ);
        }

        public async Task<string> AuthenticationAsync(AuthRQ authRQ)
        {
            var userInfo = await _taskUserRepo.GetUserByUsernameAsync(authRQ.Email);
            if (userInfo == null || userInfo.PasswordHash != authRQ.Password)
            {
                throw new ArgumentException("Invalid Username or Password");
            }

            return "JWT_TOKEN"; 
        }

        private bool IsValidUsername(string username)
        {
              if (username.Length < 3 || username.Length > 8)
            {
                return false;
            }
            if (!username.Any(char.IsLower) || !username.Any(char.IsUpper) || !username.Any(char.IsDigit) || !username.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                return false;
            }
             if (string.IsNullOrWhiteSpace(username))
            {
        return false;
            }
            return true;
        }
       
    }
}
