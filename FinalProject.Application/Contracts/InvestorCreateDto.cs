﻿using FinalProject.Domain.Entities;
using FinalProject.Domain.Enums;
namespace FinalProject.Application.Contracts
{
    public class InvestorCreateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public InvestorType Type { get; set; }
        public List<int> Contacts { get; set; }
        public List<string> Links { get; set; }
    }
}
