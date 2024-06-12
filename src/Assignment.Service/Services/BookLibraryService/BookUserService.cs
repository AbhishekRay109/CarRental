using Assignment.Api;
using Assignment.Api.Interfaces.BookLibraryInterfaces;
using Assignment.Service.Model.BookLibrary;
using Assignment.Service.Services;
using Jose.native;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace Assignment.Service.Services.BookLibraryService
{
    public class BookUserService
    {
        private readonly IDBBookUserRepository _userRepository;


        public BookUserService(IDBBookUserRepository userRepository)
        {
            _userRepository = userRepository;

        }

        public Task<List<BookUser>> GetAllUsersAsync()
        {
            return _userRepository.GetAllUsersAsync();
        }

        public Task<BookUser> GetUserByIdAsync(int userId)
        {
            return _userRepository.GetUserByIdAsync(userId);
        }

        public Task<BookUser> GetUserByUsernameAsync(string userName)
        {
            return _userRepository.GetUserByUserNameAsync(userName);
        }

        public async Task<BookUserRS> CreateUserAsync(BookUserRQ userRequest)
        {
            var existingUser = await _userRepository.GetUserByUserNameAsync(userRequest.Username);
            var existingUserId = await _userRepository.GetUserByIdAsync(userRequest.UserId);
            if (existingUser != null)
            {
                throw new InvalidOperationException("User with the same username already exists");
            }
            if (existingUserId != null)
            {
                throw new InvalidOperationException("User with the same id already exists");
            }
            var user = new BookUser
            {
                UserId = userRequest.UserId,
                Username = userRequest.Username,
                PasswordHash = userRequest.Password,
                Role = "default"
            };
            var createdUser = await _userRepository.CreateUserAsync(user);

            var responseModel = new BookUserRS(
                createdUser.UserId,
                createdUser.Username,
                createdUser.Role
                );
            return responseModel;
        }

        public Task<bool> UpdateUserAsync(int userId, BookUser updatedUser)
        {
            return _userRepository.UpdateUserAsync(userId, updatedUser);
        }

        public Task<bool> DeleteUserAsync(int userId)
        {
            return _userRepository.DeleteUserAsync(userId);
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            var user = await _userRepository.GetUserByUserNameAsync(username);

            if (user == null)
            {
                return false;
            }
            var isPasswordValid = user.PasswordHash == password;

            return isPasswordValid;
        }

        public async Task<bool> UserExistsAsync(string username, string password)
        {
            var user = await _userRepository.GetUserByUserNameAsync(username);

            if (user == null)
            {
                return false;
            }

            return VerifyPasswordHash(password, user.PasswordHash);
        }

        private bool VerifyPasswordHash(string password, string storedHash)
        {
            return password == storedHash;
        }
    }
}