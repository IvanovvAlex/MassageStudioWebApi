using MassageStudioWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassageStudioWebApi.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly MassageStudioDbContext _context;

        public ClientRepository(MassageStudioDbContext context)
        {
            this._context = context;
        }
        public async Task<Client> Create(Client client)
        {

            _context.Clients.Add(client);
            await _context.SaveChangesAsync();

            return client;
        }

        public async Task Delete(Guid id)
        {
            var clientToDelete = await _context.Clients.FindAsync(id);
            _context.Clients.Remove(clientToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Client>> Get()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task<Client> Get(Guid id)
        {
            return await _context.Clients.FindAsync(id);
        }

        public async Task Update(Client client)
        {
            _context.Entry(client).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
