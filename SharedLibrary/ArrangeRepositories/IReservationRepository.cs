using SharedLibrary.Models;

namespace SharedLibrary.ArrangeRepositories
{
    public interface IReservationRepository
    {
        Task<List<Reservation>> GetAllReservationsAsync();
        Task<Reservation> GetReservationByIdAsync(int reservationId);
        Task<bool> IsSlotReservedAsync(DateTime date, string slot);
        Task<Reservation> AddReservationAsync(Reservation model);
        Task<Reservation> UpdateReservationAsync(Reservation model);
        Task<Reservation> DeleteReservationAsync(int reservationId);
    }
}
