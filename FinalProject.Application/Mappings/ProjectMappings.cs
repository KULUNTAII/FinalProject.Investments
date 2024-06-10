

namespace FinalProject.Application.Mappings
{
    internal class ProjectMappings : Profile
    {

        public ProjectMappings()
        {
            CreateMap<Project, ProjectCreateDto>().ReverseMap();
            CreateMap<ProjectCreateDto, Project>().ReverseMap();

            CreateMap<Project, ProjectGetDto>().ReverseMap();
        }

    }
}
