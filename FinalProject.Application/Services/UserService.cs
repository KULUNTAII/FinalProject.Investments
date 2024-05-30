using AutoMapper;
using FinalProject.Domain.Enums;
using FinalProject.Application.Services.Interfaces.UnitOfWork;
using FinalProject.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using FinalProject.Controllers;

namespace ExamProject1.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<UserGetDto>> GetAllAsync()
        {
            var users = await _userRepository.GetAllAsync();
            var usersDtos = _mapper.Map<List<UserGetDto>>(users);

            return usersDtos;
        }

        public async Task<User> CreateUserAsync(UserCreateDto userDto)
        {
            if (await _userRepository.AnyAsync(u => u.Login == userDto.Login))
                throw new InvalidOperationException("User with this login already exists");

            if (await _userRepository.AnyAsync(u => u.Email == userDto.Email))
                throw new InvalidOperationException("User with this email already exists");

            var newUser = _mapper.Map<User>(userDto);

            _userRepository.Add(newUser);
            await _unitOfWork.SaveChangesAsync();

            return newUser;
        }

        public async Task<User> GetUserByIdAsync(string userId)
        {
            if (!int.TryParse(userId, out int userIdInt))
            {
                throw new InvalidOperationException("User not found");
            }
            var user = await _userRepository.GetByIdAsync(userIdInt);

            return user;
        }

    }
}