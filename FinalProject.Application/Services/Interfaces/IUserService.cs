﻿namespace FinalProject.Controllers
{
    public interface IUserService
    {
        Task<List<UserGetDto>> GetAllAsync();
        Task<User> CreateUserAsync(UserCreateDto userDto);
        Task<User?> GetUserByIdAsync(int userId);
        Task<User?> AuthenticateAsync(string username, string password);
    }
}
