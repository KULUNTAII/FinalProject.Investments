using FinalProject.Application.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/participants")]
    [ApiController]
    public class ParticipantsController(IParticipantService participantService) : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var participantDto = await participantService.GetByIdAsync(id);

            return Ok(participantDto);
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var participantDto = await participantService.GetAllAsync();

            return Ok(participantDto);
        }

        [HttpPost]
        public async Task<ActionResult> Create(ParticipantCreateDto participantDto)
        {
            await participantService.CreateAsync(participantDto);

            return NoContent();
        }
    }
}
