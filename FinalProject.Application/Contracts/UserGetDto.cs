using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Application.Contracts
{
    internal class UserGetDto
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Role { get; set; }
    }
}
