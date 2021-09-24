using MassageStudioWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassageStudioWebApi.Repositories
{
    public interface IMasseurRepository
    {
        Task<IEnumerable<Masseur>> Get();
        Task<Masseur> Get(Guid id);
        Task<Masseur> Create(Masseur reservation);
        Task Update(Masseur reservation);
        Task Delete(Guid id);
    }
}
