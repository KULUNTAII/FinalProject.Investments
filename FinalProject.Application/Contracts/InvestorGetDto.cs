using FinalProject.Domain.Entities;
using FinalProject.Domain.Enums;
namespace FinalProject.Application.Contracts
{
    public class InvestorGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public InvestorType Type { get; set; }
        public List<Project> InvestedProjects { get; set; }
        public List<int> Contacts { get; set; }
        public string Email { get; set; }
        public List<string> Links { get; set; }
        public string Country { get; set; }

    }
}
