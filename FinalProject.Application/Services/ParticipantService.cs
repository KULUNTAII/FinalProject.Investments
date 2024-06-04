using FinalProject.Application.Services.Interfaces.UnitOfWork;
using FinalProject.Domain.Repositories;

public class ParticipantService : IParticipantService
{
    private readonly IParticipantRepository participantRepository;
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public ParticipantService(IParticipantRepository participantRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.participantRepository = participantRepository;
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    public async Task<ParticipantGetDto?> GetByIdAsync(int id)
    {
        var participant = await participantRepository.GetByIdAsync(id);

        if (participant is null) return null;

        var participantDto = mapper.Map<ParticipantGetDto>(participant);

        return participantDto;
    }

    public async Task<List<ParticipantGetDto>> GetAllAsync()
    {
        var participants = await participantRepository.GetAllAsync();

        var participantDtos = mapper.Map<List<ParticipantGetDto>>(participants);

        return participantDtos;
    }

    public async Task CreateAsync(ParticipantCreateDto participantDto)
    {
        var participant = mapper.Map<Participant>(participantDto);

        participantRepository.Add(participant);
        var participantGetDto = mapper.Map<ParticipantGetDto>(participant);
        await unitOfWork.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var participant = await participantRepository.GetByIdAsync(id);

        if (participant is null) return;

        participantRepository.Remove(participant);

        await unitOfWork.SaveChangesAsync();
    }
}