using SharedLibrary.ReservationRepositories1;
using SharedLibrary.Models;
using System.Net.Http.Json;

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
        public async Task<List<Reservation>> GetReservationByDateAsync(DateTime startDate, DateTime endDate)
        {
            var response = await httpClient.GetFromJsonAsync<List<Reservation>>($"api/Reservation/daterange?startDate={startDate:yyyy-MM-dd}&endDate={endDate:yyyy-MM-dd}");
            var reservations = response ?? new List<Reservation>();

            Console.WriteLine($"Retrieved {reservations.Count} reservations"); // 添加日志
            foreach (var res in reservations)
            {
                Console.WriteLine($"Reservation ID: {res.Id}, Day: {res.Day}, Slot: {res.SlOt}, BedId: {res.BedId}");
            }

            return reservations;
        }

    }
}
