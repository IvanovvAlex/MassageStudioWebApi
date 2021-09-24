using MassageStudioWebApi.Models;
using MassageStudioWebApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassageStudioWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;

        public ClientsController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Client>> GetClients()
        {
            return await _clientRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> GetClient(Guid id)
        {
            return await _clientRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Client>> PostClients([FromBody] Client client)
        {
            var newClient = await _clientRepository.Create(client);
            return CreatedAtAction(nameof(GetClients), new { id = newClient.ClientId }, newClient);
        }

        [HttpPut]
        public async Task<ActionResult> PutClients(Guid id, [FromBody] Client client)
        {
            if (id != client.ClientId)
            {
                return BadRequest();
            }

            await _clientRepository.Update(client);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var clientToDelete = await _clientRepository.Get(id);

            if (clientToDelete == null)
            {
                return NotFound();
            }

            await _clientRepository.Delete(clientToDelete.ClientId);
            return NoContent();
        }
    }
}
