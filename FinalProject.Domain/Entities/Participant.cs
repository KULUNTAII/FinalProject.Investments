using System.ComponentModel.DataAnnotations;
using FinalProject.Domain.Enums;

namespace FinalProject.Domain.Entities
{
    public class Participant
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public required Qualifications Qualification { get; set; }
        public List<string> WorkExperience{ get; set; }
        public List<string> Awards { get; set; }
        public Skills Skills { get; set; }
        public Project Projects { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        public int PhoneNumber { get; set; }
        public List<string> Links { get; set; }
    }
}