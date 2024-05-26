using FinalProject.Domain.Entities;
using FinalProject.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Application.Contracts
{
    public class ParticipantCreateDto
    {
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public QualificationTypeEnum Qualification { get; set; }
        public List<string> WorkExperience { get; set; }
        public List<string> Awards { get; set; }
        public Skills Skills { get; set; }
        public Project Projects { get; set; }
        public List<string> Links { get; set; }
        public string Country { get;set; }
    }
}
