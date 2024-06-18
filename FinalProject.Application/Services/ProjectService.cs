using FinalProject.Application.Services.Interfaces.UnitOfWork;
using FinalProject.Domain.Repositories;

public class ProjectService : IProjectService
{
    private readonly IProjectRepository projectRepository;
    private readonly IAuthService authService;
    private readonly IUserRepository userRepository;
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public ProjectService(IProjectRepository projectRepository, IUnitOfWork unitOfWork, IMapper mapper, IUserRepository userRepository, IAuthService authService)
    {
        this.projectRepository = projectRepository;
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
        this.userRepository = userRepository;
        this.authService = authService;
    }

    public async Task<ProjectGetDto?> GetByIdAsync(int id)
    {
        var project = await projectRepository.GetByIdAsync(id);

        if (project is null) return null;

        var projectDto = mapper.Map<ProjectGetDto>(project);

        return projectDto;
    }

    public async Task<List<ProjectGetDto>> GetAllAsync()
    {
        var projects = await projectRepository.GetAllAsync();

        var projectDtos = mapper.Map<List<ProjectGetDto>>(projects);

        return projectDtos;
    }

    public async Task CreateAsync(ProjectCreateDto projectDto)
    {
        var project = mapper.Map<Project>(projectDto);

        var user = await authService.GetCurrentLoggedInUser();
        //if (await projectRepository.AnyAsync(u => u.Name == project.Name))
        //    throw new InvalidOperationException("Project with this name already exists.");

        user.Participant.Projects.Add(project);

        userRepository.Update(user);

        await unitOfWork.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var project = await projectRepository.GetByIdAsync(id);

        if (project is null) return;

        projectRepository.Remove(project);

        await unitOfWork.SaveChangesAsync();
    }
}
