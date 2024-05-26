using FinalProject.Domain.Entities;
using FinalProject.Domain.Repositories;
using FinalProject.Infrastructure.Data.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Infrastructure.Data.Repositories
{
    public class ParticipantRepository(AppDbContext dbContext)
    : BaseRepository<Participant>(dbContext), IParticipantRepository
    {
    };
}
