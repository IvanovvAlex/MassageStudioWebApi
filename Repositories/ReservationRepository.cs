using MassageStudioWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassageStudioWebApi.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly MassageStudioDbContext _context;

        public ReservationRepository(MassageStudioDbContext context)
        {
            this._context = context;
        }
        public async Task<Reservation> Create(Reservation reservation)
        {
            
            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync();

            return reservation;
        }

        public async Task Delete(Guid id)
        {
            var ReservationToDelete = await _context.Reservations.FindAsync(id);
            _context.Reservations.Remove(ReservationToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Reservation>> Get()
        {
            return await _context.Reservations.ToListAsync();
        }

        public async Task<Reservation> Get(Guid id)
        {
            return await _context.Reservations.FindAsync(id);
        }

        public async Task Update(Reservation reservation)
        {
            _context.Entry(reservation).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
