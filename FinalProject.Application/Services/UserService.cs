using FinalProject.Application.Services.Interfaces.UnitOfWork;
using FinalProject.Controllers;

namespace FinalProject.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordManager _passwordManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork, IMapper mapper, IPasswordManager passwordManager)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _passwordManager = passwordManager;
        }

        public async Task<List<UserGetDto>> GetAllAsync()
        {
            var users = await _userRepository.GetAllAsync();
            var usersDtos = _mapper.Map<List<UserGetDto>>(users);

            return usersDtos;
        }
        public async Task<UserGetDto?> UpdateUserAsync(int id, UserCreateDto genreDto)
        {
            var user = await GetUserByIdAsync(id);

            if (user is null) return null;

            user.Login = genreDto.Login!;

            _userRepository.Update(user);

            await _unitOfWork.SaveChangesAsync();

            var userGetDto = new UserGetDto
            {
                Id = user.Id,
                Login = user.Login,
            };

            return userGetDto;
        }
        public async Task<User> CreateUserAsync(UserCreateDto userDto)
        {
            if (await _userRepository.AnyAsync(u => u.Login == userDto.Login))
                throw new InvalidOperationException("User with this login already exists");

            var newUser = _mapper.Map<User>(userDto);

            newUser.PasswordHash = _passwordManager.HashPassword(userDto.Password!);

            _userRepository.Add(newUser);
            await _unitOfWork.SaveChangesAsync();

            return newUser;
        }

        public async Task<User?> GetUserByIdAsync(int userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);

            return user;
        }

        public async Task<User?> AuthenticateAsync(string username, string password)
        {
            var users = await _userRepository.GetAllAsync(); // Ждем завершения задачи
            var user = users.FirstOrDefault(u => u.Login == username);

            if (user == null || !_passwordManager.VerifyPassword(password, user.PasswordHash))
            {
                return null;
            }

            return user;
        }
    }
}