using Microsoft.AspNetCore.Mvc;
using SharedLibrary.ReservationRepositories1;
using SharedLibrary.Models;

namespace Arrangementdata.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationRepository reservationRepository;
        public ReservationController(IReservationRepository reservationrepository)
        {
            this.reservationRepository = reservationRepository;
        }
        [HttpGet("All-Reservations")]
        public async Task<ActionResult<List<Reservation>>> GetAllReservationsAsync()
        {
            var reservations = await reservationRepository.GetAllReservationsAsync();
            return Ok(reservations);
        }

        [HttpGet("single-Reservation/{Id}")]
        public async Task<ActionResult<List<Reservation>>> GetSingleReservationAsync(int id)
        {
            var reservation = await reservationRepository.GetReservationByIdAsync(id);
            return Ok(reservation);
        }

        [HttpPost("Add-Reservation")]
        public async Task<ActionResult<List<Reservation>>> AddReservationAsync(Reservation model)
        {
            var reservation = await reservationRepository.AddReservationAsync(model);
            return Ok(reservation);
        }

        [HttpPut("Update-Reservation")]
        public async Task<ActionResult<List<Reservation>>> UpdateReservationAsync(Reservation model)
        {
            var reservation = await reservationRepository.UpdateReservationAsync(model);
            return Ok(reservation);
        }

        [HttpDelete("Delete-Reservation/{Id}")]
        public async Task<ActionResult<List<Reservation>>> DeleteReservationAsync(int Id)
        {
            var reservation = await reservationRepository.DeleteReservationAsync(Id);
            return Ok(reservation);
        }

        [HttpGet("Is-Slot-Reserved")]
        public async Task<ActionResult<bool>> IsSlotReservedAsync(DateTime date, string slot)
        {
            var isreserved = await reservationRepository.IsSlotReservedAsync(date, slot);
            return Ok(isreserved);
        }

        [HttpGet("daterange")]
        public async Task<ActionResult<List<Reservation>>> GetReservationByDate([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            var reservations = await reservationRepository.GetReservationByDateAsync(startDate, endDate);
            return Ok(reservations);
        }
    }
}
