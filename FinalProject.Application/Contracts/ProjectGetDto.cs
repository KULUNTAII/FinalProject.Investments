using FinalProject.Domain.Enums;

namespace FinalProject.Application.Contracts
{
    public class ProjectGetDto
    {

        public int Id { get; set; }
        public required string Name { get; set; }
        public ProjectCategories Category { get; set; }
        public string PreviewDescription { get; set; }
        public string FullDescription { get; set; }
        public List<Investor> Investors { get; set; }
        public int TeamsBudget { get; set; }
        public int RequiredBudget { get; set; }
        public List<Participant> Participants { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime Deadline { get; set; }
        public List<string> Contacts { get; set; }
        public string Links { get; set; }
        public string Country { get; set; }
        public int FavoritesCount { get; set; }
        public List<string> Comments { get; set; }

    }

}

