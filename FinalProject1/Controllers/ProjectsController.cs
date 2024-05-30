using FinalProject.Application.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectsController(IProjectService projectService) : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var projectDto = await projectService.GetByIdAsync(id);

            return Ok(projectDto);
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var projectDtos = await projectService.GetAllAsync();

            return Ok(projectDtos);
        }

        [HttpPost]
        public async Task<ActionResult> Create(ProjectCreateDto projectDto)
        {
            await projectService.CreateAsync(projectDto);

            return NoContent();
        }
    }

}
