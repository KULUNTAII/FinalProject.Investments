using FinalProject.Domain.Abstractions;
using FinalProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Domain.Repositories
{
    public interface IParticipantRepository : IRepository<Participant>
    {
        Task<Participant> Follow(int praticipantId, int followerId);
    }
}
