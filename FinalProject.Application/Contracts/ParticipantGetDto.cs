using FinalProject.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Application.Contracts
{
    public class ParticipantGetDto
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public required QualificationTypeEnum Qualification { get; set; }
        public List<string> WorkExperience { get; set; }
        public List<string> Awards { get; set; }
        public Skills Skills { get; set; }
        public Project Projects { get; set; }

        [Required]
        [EmailAddress]
        public int PhoneNumber { get; set; }
        public List<string> Links { get; set; }
        public string Country { get; set; }
    }
}
