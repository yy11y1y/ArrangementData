using SharedLibrary.Models;
using static SharedLibrary.Models.Arrange;

namespace SharedLibrary.ArrangeRepositories
{
    public interface IReservationRepository
    {
        Task<Arrange> AddArrangeAsync(Arrange model);
        Task<Arrange> UpdateArrangeAsync(Arrange model);
        Task<Arrange> DeleteArrangeAsync(int arrangeId);
        Task<List<Arrange>> GetAllArrangesAsync();
        Task<Arrange> GetArrangeByIdAsync(int arrangeId);
        //Task<Arrange> GetArrangementAsync(string bedId, DateTime date, TimeSlot slot);
        Task<IEnumerable<Arrange>> GetArrangementAsync(string Bed_Id, DateTime Date, TimeSlot Slot, bool IsReserved , string Patient_Id );
    }
}
