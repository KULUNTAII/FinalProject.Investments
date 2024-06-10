using FinalProject.Domain.Abstractions;
using FinalProject.Domain.Enums;

namespace FinalProject.Domain.Entities
{
    public class Investor : Entity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public List<int>? Contacts { get; set; }
        public List<string>? Links { get; set; }
        public List<Project>? InvestedProjects { get; set; }
    }
}