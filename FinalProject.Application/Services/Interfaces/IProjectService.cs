
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IProjectService
{
    Task<ProjectGetDto?> GetByIdAsync(int id);
    Task<List<ProjectGetDto>> GetAllAsync();
    Task CreateAsync(ProjectCreateDto projectDto);
    Task DeleteAsync(int id);
}