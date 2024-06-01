using FinalProject.Domain.Abstractions;
using FinalProject.Domain.Enums;

namespace FinalProject.Domain.Entities
{
    public class Project : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProjectCategories Category { get; set; }
        public string PreviewDescription { get; set; }
        public string FullDescription { get; set; }
        public int TeamsBudget { get; set; }
        public int RequiredBudget { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime Deadline { get; set; }
        public List<string>? Contacts { get; set; }
        public string? Links { get; set; }
        public int? FavoritesCount { get; set; }
        public List<Investor>? Investors { get; set; }
        public required List<Participant> Participants { get; set; }

    }
}
