﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Application.Mappings
{
    internal class ParticipantMappings : Profile
    {
        public ParticipantMappings() 
        {
            CreateMap<Participant, ParticipantCreateDto>().ReverseMap();
            CreateMap<ParticipantCreateDto, Participant>().ReverseMap();
        }
    }
}
