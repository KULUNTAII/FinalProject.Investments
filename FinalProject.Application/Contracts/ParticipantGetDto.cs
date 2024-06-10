using FinalProject.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Application.Contracts
{
    public class ParticipantGetDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public string Qualification { get; set; }
        public List<string> WorkExperience { get; set; }
        public List<string> Awards { get; set; }
        public string Skills { get; set; }
        public Project Projects { get; set; }
        public int PhoneNumber { get; set; }
        public List<string> Links { get; set; }
    }
}
