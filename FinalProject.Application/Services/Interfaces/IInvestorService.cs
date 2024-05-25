public interface IInvestorService
{
    public Task<InvestorGetDto?> GetByIdAsync(int id);
    public Task<List<InvestorGetDto>> GetAllAsync();
    public Task CreateAsync(InvestorCreateDto artistDto);
    public Task DeleteAsync(int id);
    //public Task<bool> AddFollowerAsync(int id);
}