using MassageStudioWebApi.Repositories;
using MassageStudioWebApi.Models;
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
    public class MasseursController : ControllerBase
    {
        private readonly IMasseurRepository _masseurRepository;

        public MasseursController(IMasseurRepository masseurRepository)
        {
            _masseurRepository = masseurRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Masseur>> GetMasseurs()
        {
            return await _masseurRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Masseur>> GetMasseurs(Guid id)
        {
            return await _masseurRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Masseur>> PostMasseurs([FromBody] Masseur masseur)
        {
            var newMasseur = await _masseurRepository.Create(masseur);
            return CreatedAtAction(nameof(GetMasseurs), new { id = newMasseur.MasseurId }, newMasseur);
        }

        [HttpPut]
        public async Task<ActionResult> PutMasseurs(Guid id, [FromBody] Masseur masseur)
        {
            if (id != masseur.MasseurId)
            {
                return BadRequest();
            }

            await _masseurRepository.Update(masseur);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var masseurToDelete = await _masseurRepository.Get(id);

            if (masseurToDelete == null)
            {
                return NotFound();
            }

            await _masseurRepository.Delete(masseurToDelete.MasseurId);
            return NoContent();
        }
    }
}
