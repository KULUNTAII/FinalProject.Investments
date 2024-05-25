using FinalProject.Application.Services.Interfaces.UnitOfWork;
using FinalProject.Domain.Repositories;

public class InvestorService(
    IInvestorRepository investorRepository,
    IUnitOfWork unitOfWork,
    IMapper mapper) : IInvestorService
{
    public async Task<InvestorGetDto?> GetByIdAsync(int id)
    {
        var investor = await investorRepository.GetByIdAsync(id);

        if (investor is null) return null;

        var investorDto = mapper.Map<InvestorGetDto>(investor);

        return investorDto;
    }

    public async Task<List<InvestorGetDto>> GetAllAsync()
    {
        var investors = await investorRepository.GetAllAsync();

        var investorDtos = mapper.Map<List<InvestorGetDto>>(investors);

        return investorDtos;
    }

    public async Task CreateAsync(InvestorCreateDto investorDto)
    {
        var investor = mapper.Map<Investor>(investorDto);

        investorRepository.Add(investor);

        await unitOfWork.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var investor = await investorRepository.GetByIdAsync(id);

        if (investor is null) return;

        investorRepository.Remove(investor);

        await unitOfWork.SaveChangesAsync();
    }

}
