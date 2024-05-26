public interface IParticipantService
{
    public Task<ParticipantGetDto?> GetByIdAsync(int id);
    public Task<List<ParticipantGetDto>> GetAllAsync();
    public Task CreateAsync(ParticipantCreateDto artistDto);
    public Task DeleteAsync(int id);
}