using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Interfaces;
using Assignment.Api.Models.QuizGame;
using Assignment.Service.Model.QuizGame;

namespace Assignment.Service.Services.QuizGame
{
    public class QuizUserService
    {
        private readonly IDBQuizUserRepository _userRepository;

        public QuizUserService(IDBQuizUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<QuizUserRS> RegisterUserAsync(QuizUserRQ quizUserRequest)
        {
            try
            {
                if (!IsValidEmail(quizUserRequest.Email))
                {
                    throw new ArgumentException("Invalid Email ID");
                }

                if (!IsPasswordValid(quizUserRequest.Password))
                {
                    throw new ArgumentException("Password does not meet the required criteria");
                }

                QuizUser quizUserModel = new QuizUser
                {
                    Username = quizUserRequest.Username,
                    Email = quizUserRequest.Email,
                    Password = quizUserRequest.Password
                };

                var quizUserOutput = await _userRepository.RegisterUserAsync(quizUserModel);

                var quizUserResponse = new QuizUserRS
                {
                    Username = quizUserOutput.Username,
                    Email = quizUserOutput.Email
                };

                return quizUserResponse;
            }
            catch
            {
                throw;
            }
        }

        public bool IsValidUser(string email, string password)
        {
            return _userRepository.IsValidUser(email, password);
        }

        public async Task<List<QuizUser>> GetAllUsersAsync()
        {
            try
            {
                var users = await _userRepository.GetAllUsersAsync();

                return users;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving users: {ex.Message}");
            }
        }

        public async Task<QuizUserRS> UpdateUserAsync(int userId, QuizUserRQ updatedUserData)
        {
            try
            {
                var existingUser = await _userRepository.GetUserByIdAsync(userId);

                if (existingUser != null)
                {
                    if (!IsValidEmail(updatedUserData.Email))
                    {
                        throw new ArgumentException("Invalid Email ID");
                    }

                    if (!IsPasswordValid(updatedUserData.Password))
                    {
                        throw new ArgumentException("Password does not meet the required criteria");
                    }

                    existingUser.Username = updatedUserData.Username;
                    existingUser.Email = updatedUserData.Email;
                    existingUser.Password = updatedUserData.Password;

                    await _userRepository.UpdateUserAsync(existingUser);

                    var updatedUserResponse = new QuizUserRS
                    {
                        Username = existingUser.Username,
                        Email = existingUser.Email
                    };

                    return updatedUserResponse;
                }
                else
                {
                    throw new KeyNotFoundException($"User with ID {userId} not found");
                }
            }
            catch
            {
                throw;
            }
        }
         

        private bool IsValidEmail(string email)
        {
            return !string.IsNullOrEmpty(email) && email.Contains("@");
        }

        private bool IsPasswordValid(string password)
        {
            if (password.Length < 4 || password.Length > 12)
            {
                return false;
            }
            if (!password.Any(char.IsLower) || !password.Any(char.IsUpper) || !password.Any(char.IsDigit) || !password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                return false;
            }
            return true;
        }

        
    }
}