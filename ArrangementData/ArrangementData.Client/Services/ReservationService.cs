using SharedLibrary.ReservationRepositories1;
using SharedLibrary.Models;
using System.Net.Http.Json;
using static SharedLibrary.Models.Reservation;

namespace ArrangementData.Client.Services
{
    public class ReservationService : IReservationRepository
    {
        private readonly HttpClient httpClient;
        public ReservationService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<Reservation>> GetAllReservationsAsync()
        {
            var reservations = await httpClient.GetAsync("api/Reservation/All-Reservations");
            var response = await reservations.Content.ReadFromJsonAsync<List<Reservation>>();
            return response!;
        }
        public async Task<Reservation> GetReservationByIdAsync(int reservationId)
        {
            var reservation = await httpClient.GetAsync($"api/Reservation/Single-Reservation/{reservationId}");
            var response = await reservation.Content.ReadFromJsonAsync<Reservation>();
            return response!;
        }
        public async Task<bool> IsSlotReservedAsync(DateTime date, string slot)
        {
            var reservations = await GetAllReservationsAsync();
            return reservations.Any(r => r.Day.Date == date.Date && r.SlOt == slot && !string.IsNullOrEmpty(r.PatientId));
        }
        public async Task<Reservation> AddReservationAsync(Reservation model)
        {
            var reservation = await httpClient.PostAsJsonAsync("api/Reservation/Add-Reservation", model);
            var response = await reservation.Content.ReadFromJsonAsync<Reservation>();
            return response!;
        }
        public async Task<Reservation> DeleteReservationAsync(int reservationId)
        {
            var reservation = await httpClient.DeleteAsync($"api/Arrange/Delete-Arrange/ {reservationId}");
            var response = await reservation.Content.ReadFromJsonAsync<Reservation>();
            return response!;
        }
        public async Task<Reservation> UpdateReservationAsync(Reservation model)
        {
            var reservation = await httpClient.PutAsJsonAsync("api/Reservation/Update-Reservation", model);
            var response = await reservation.Content.ReadFromJsonAsync<Reservation>();
            return response!;
        }
    }
}
