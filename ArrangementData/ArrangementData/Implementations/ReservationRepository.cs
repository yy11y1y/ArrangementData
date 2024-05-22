using SharedLibrary.ReservationRepositories1;
using ArrangementData.Data;
using SharedLibrary.Models;
using Microsoft.EntityFrameworkCore;
using static SharedLibrary.Models.Reservation;

namespace ArrangementData.Implementions
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly AppDbContext appDbContext;

        public ReservationRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<bool> IsSlotReservedAsync(DateTime date, string slot)
        {
            return await appDbContext.Reservations.AllAsync(r => r.Day.Date == date.Date && r.SlOt == slot && !string.IsNullOrEmpty(r.PatientId));
        }
        public async Task<List<Reservation>> GetAllReservationsAsync() => await appDbContext.Reservations.ToListAsync();

        public async Task<Reservation> GetReservationByIdAsync(int reservationId)
        {
            var reservation = await appDbContext.Reservations.FirstOrDefaultAsync(_ => _.Id == reservationId);
            if (reservation is null) return null!;
            return reservation;
        }

        public async Task<Reservation> AddReservationAsync(Reservation model)
        {
            if (model is null) return null!;
            var chk = await appDbContext.Reservations.Where(_ => _.PatientId.ToLower().Equals(model.PatientId.ToLower())).FirstOrDefaultAsync();
            if (chk is not null) return null!;

            var newDataAdded = appDbContext.Reservations.Add(model).Entity;
            await appDbContext.SaveChangesAsync();
            return newDataAdded;
        }

        public async Task<Reservation> UpdateReservationAsync(Reservation model)
        {
            var reservation = await appDbContext.Reservations.FirstOrDefaultAsync(_ => _.Id == model.Id);
            if (reservation is null) return null!;
            reservation.NursingStation = model.NursingStation;
            reservation.BedId = model.BedId;
            reservation.Day = model.Day;
            reservation.PatientId = model.PatientId;
            reservation.SlOt = model.SlOt;
            reservation.OperatOr = model.OperatOr;
            reservation.OperatingTime = model.OperatingTime;

            return await appDbContext.Reservations.FirstOrDefaultAsync(_ => _.Id == model.Id)!;
        }

        public async Task<Reservation> DeleteReservationAsync(int reservationId)
        {
            var reservation = await appDbContext.Reservations.FirstOrDefaultAsync(_ => _.Id == reservationId);
            if (reservation is null) return null!;
            appDbContext.Reservations.Remove(reservation);
            await appDbContext.SaveChangesAsync();
            return reservation;
        }
    }
}