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
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationRepository _reservationRepository;

        public ReservationsController(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Reservation>> GetReservations()
        {
            return await _reservationRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Reservation>> GetReservations(Guid id)
        {
            return await _reservationRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Reservation>> PostReservations([FromBody] Reservation reservation)
        {                                   
            var newReservation = await _reservationRepository.Create(reservation);
            return CreatedAtAction(nameof(GetReservations), new { id = newReservation.ReservationId }, newReservation);
        }

        [HttpPut]
        public async Task<ActionResult> PutReservations(Guid id, [FromBody] Reservation reservation)
        {
            if (id != reservation.ReservationId)
            {
                return BadRequest();
            }

            await _reservationRepository.Update(reservation);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var reservationToDelete = await _reservationRepository.Get(id);

            if (reservationToDelete == null)
            {
                return NotFound();
            }

            await _reservationRepository.Delete(reservationToDelete.ReservationId);
            return NoContent();
        }

    }
}
