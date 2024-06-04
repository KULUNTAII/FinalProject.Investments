using FinalProject.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Application.Contracts
{
    public class ParticipantCreateDto
    {
        [Required(AllowEmptyStrings = false)]
        [StringLength(20)]
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public QualificationTypeEnum Qualification { get; set; }
        public List<string>? WorkExperience { get; set; }
        public List<string>? Awards { get; set; }
        public Skills? Skills { get; set; }
        public List<string>? Links { get; set; }
        public string? Country { get;set; }
    }
}
