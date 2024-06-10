namespace FinalProject.Application.Mappings
{
    internal class ParticipantMappings : Profile
    {
        public ParticipantMappings() 
        {
            CreateMap<Participant, ParticipantCreateDto>().ReverseMap();
            CreateMap<ParticipantCreateDto, Participant>().ReverseMap();

            CreateMap<Participant, ParticipantGetDto>().ReverseMap();
        }
    }
}
