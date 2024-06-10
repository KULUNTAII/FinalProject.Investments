using FinalProject.Domain.Enums;

namespace FinalProject.Application.Contracts
{
    public class ProjectCreateDto
    {
        public string Name { get; set; }
        public ProjectCategories Category { get; set; }
        public string Description { get; set; }
        public string PreviewDescription { get; set; }
        public int TeamsBudget { get; set; }
        public int RequiredBudget { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime Deadline { get; set; }
        public List<int> Contacts { get; set; }
        public string Links { get; set; }
        public string Country { get; set; }
    }
}
