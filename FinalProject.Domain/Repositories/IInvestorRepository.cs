using FinalProject.Domain.Abstractions;
using FinalProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Domain.Repositories
{
    public interface IInvestorRepository : IRepository<Investor>
    {
        Task<Investor> SortByCountry(string country);
    }
}
