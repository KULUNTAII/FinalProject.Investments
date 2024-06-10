using FinalProject.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Application.Contracts
{
    public class ParticipantCreateDto
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Bio {  get; set; }
        public List<string>? WorkExperience { get; set; }
        public List<string>? Achievements { get; set; }
        public string? Skills { get; set; }
        public string? Qualification { get; set; }
        public List<string>? Links { get; set; }
    }
}
