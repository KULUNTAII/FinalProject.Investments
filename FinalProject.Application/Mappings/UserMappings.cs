namespace FinalProject.Application.Mappings
{
    public class UserMappings : Profile
    {
        public UserMappings()
        {
            CreateMap<User, UserCreateDto>().ReverseMap();
            CreateMap<UserCreateDto, User>().ReverseMap();
        }
    }
}
