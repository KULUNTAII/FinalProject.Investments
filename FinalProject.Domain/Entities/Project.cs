using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Domain.Enums;

namespace FinalProject.Domain.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProjectCategories Category { get; set; }
        public string Description { get; set; }
        public List<Investor> Investors { get; set; }
        public int TeamsBudget { get; set; }
        public int RequiredBudget { get; set; }
        public List<Participant> Participants { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime Deadline { get; set; }
        public List<int> Contacts { get; set; }
        public string Links { get; set; }

    }
}
