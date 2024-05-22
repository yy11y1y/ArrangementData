using SharedLibrary.Models;

namespace SharedLibrary.ArrangeRepositories
{
    public interface IArrangeRepository 
    {
        Task<List<Arrange>> GetAllArrangesAsync();
        Task<Arrange> GetArrangeByIdAsync(int arrangeId);
        Task<Arrange> AddArrangeAsync(Arrange model);
        Task<Arrange> UpdateArrangeAsync(Arrange model);
        Task<Arrange> DeleteArrangeAsync(int arrangeId);
    }
}
