using MassageStudioWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassageStudioWebApi.Repositories
{
    public class MasseurRepository : IMasseurRepository
    {
        private readonly MassageStudioDbContext _context;

        public MasseurRepository(MassageStudioDbContext context)
        {
            this._context = context;
        }

        public async Task<Masseur> Create(Masseur masseur)
        {

            _context.Masseurs.Add(masseur);
            await _context.SaveChangesAsync();

            return masseur;
        }

        public async Task Delete(Guid id)
        {
            var MasseurToDelete = await _context.Masseurs.FindAsync(id);
            _context.Masseurs.Remove(MasseurToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Masseur>> Get()
        {
            return await _context.Masseurs.ToListAsync();
        }

        public async Task<Masseur> Get(Guid id)
        {
            return await _context.Masseurs.FindAsync(id);
        }

        public async Task Update(Masseur masseur)
        {
            _context.Entry(masseur).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
