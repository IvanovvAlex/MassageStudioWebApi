using MassageStudioWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassageStudioWebApi.Repositories
{
    public interface IReservationRepository
    {
        Task<IEnumerable<Reservation>> Get();
        Task<Reservation> Get(int id);
        Task<Reservation> Create(Reservation reservation);
        Task Update(Reservation reservation);
        Task Delete(int id);

    }
}
