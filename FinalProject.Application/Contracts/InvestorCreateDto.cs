using FinalProject.Domain.Enums;
using System.ComponentModel.DataAnnotations;
namespace FinalProject.Application.Contracts
{
    public class InvestorCreateDto
    {
        [Required(AllowEmptyStrings = false)]
        [StringLength(20)]
        public string? Name { get; set; }
        public string? Description { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(20)]
        public string Type { get; set; }
        public List<int>? Contacts { get; set; }
        public List<string>? Links { get; set; }
    }
}
