using AutoMapper;
using FinalProject.Application.Contracts;
using FinalProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Application.Mappings
{
    internal class InvestorMappings : Profile 
    {
        public InvestorMappings()
        {
            CreateMap<Investor, InvestorCreateDto>().ReverseMap();
            CreateMap<InvestorCreateDto, Investor>().ReverseMap();
        }
    }
}
