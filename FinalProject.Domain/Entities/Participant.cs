using FinalProject.Domain.Abstractions;
using FinalProject.Domain.Enums;

namespace FinalProject.Domain.Entities
{
    public class Participant : Entity
    {
        public List<string>? WorkExperience { get; set; }
        public List<string>? Awards { get; set; }
        public Skills Skills { get; set; }
        public int PhoneNumber { get; set; }
        public List<string>? Links { get; set; }
        public required List<QualificationType> QualificationType { get; set; }
        public List<Project>? Projects { get; set; }
    }
}