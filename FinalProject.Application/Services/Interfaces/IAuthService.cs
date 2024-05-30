﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Application.Services.Interfaces
{
    public interface IAuthService
    {
        Task<User> LoginWithHttpContext(string email, string password);
    }
}
