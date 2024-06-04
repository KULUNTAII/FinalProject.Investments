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
