using MassageStudioWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassageStudioWebApi.Repositories
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> Get();
        Task<Client> Get(Guid id);
        Task<Client> Create(Client reservation);
        Task Update(Client reservation);
        Task Delete(Guid id);
    }
}
