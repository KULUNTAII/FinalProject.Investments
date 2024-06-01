using FinalProject.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Application.Contracts
{
    public class UserCreateDto
    {
        [Required(AllowEmptyStrings = false)]
        [StringLength(20)]
        public string? Login { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [StringLength(50)]
        public string? Password { get; set; }

        [Required]
        public Roles? Role { get; set; }
    }
}
