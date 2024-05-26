using SpotiPie.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Application.Services.Interfaces
{
    public interface IUserService
    {
        public Task<UserGetDto> SignUpAsync(UserCredentialsDto userDto);
        public Task<UserGetDto?> GetByLoginAsync(UserCredentialsDto userDto);
    }

}
