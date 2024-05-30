public interface IInvestorService
{
    public Task<InvestorGetDto?> GetByIdAsync(int id);
    public Task<List<InvestorGetDto>> GetAllAsync();
    Task CreateAsync(InvestorCreateDto investorDto);
    public Task DeleteAsync(int id);
    //public Task<bool> AddFollowerAsync(int id);
}