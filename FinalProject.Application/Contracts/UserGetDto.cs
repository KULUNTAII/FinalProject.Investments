using FinalProject.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Application.Contracts
{
    public record UserGetDto
    {
        public int Id { get; set; }
        public string? Login { get; set; }
        public Roles Role { get; set; }
    }
}
