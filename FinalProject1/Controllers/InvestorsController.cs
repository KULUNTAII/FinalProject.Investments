using FinalProject.Application.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [ApiController]
    [Route("api/investors")]
    public class InvestorsController(IInvestorService investorService) : ControllerBase
    {
        [HttpGet("{id}")]
        [HttpPost]
        public async Task<IActionResult> Create(InvestorCreateDto investorDto)
        {
            await investorService.CreateAsync(investorDto);
            return NoContent();
        }
    }
}
