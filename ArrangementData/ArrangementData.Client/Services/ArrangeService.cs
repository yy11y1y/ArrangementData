using SharedLibrary.ArrangeRepositories;
using SharedLibrary.Models;
using System.Net.Http.Json;
using static SharedLibrary.Models.Arrange;

namespace ArrangementData.Client.Services
{
    public class ArrangeService : IArrangeRepository
    {
        private readonly HttpClient httpClient;

        public ArrangeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<Arrange> AddArrangeAsync(Arrange model)
        {
            var arrange = await httpClient.PostAsJsonAsync("api/Arrang/Add-Arrange", model);
            var response = await arrange.Content.ReadFromJsonAsync<Arrange>();
            return response!;
        }

        public async Task<Arrange> DeleteArrangeAsync(int arrangeId)
        {
            var arrange = await httpClient.DeleteAsync($"api/Arrange/Delete-Arrange/ {arrangeId}");
            var response = await arrange.Content.ReadFromJsonAsync<Arrange>();
            return response!;
        }

        public async Task<List<Arrange>> GetAllArrangesAsync()
        {
            var arranges = await httpClient.GetAsync("api/Arrange/All-Arranges");
            var response = await arranges.Content.ReadFromJsonAsync<List<Arrange>>();
            return response!;
        }
        public async Task<IEnumerable<Arrange>> GetArrangementAsync(string Bed_Id, DateTime Date, TimeSlot Slot, bool IsReserved , string Patient_Id)
        {
            var arranges = await httpClient.GetAsync($"api/Arrange?Bed_Id={Bed_Id}&Date={Date:yyyy-MM-dd}&Slot={Slot}&IsReserved={IsReserved}&Patient_Id={Patient_Id}");
            var response = await arranges.Content.ReadFromJsonAsync<IEnumerable<Arrange>>();
            return response!;
        }

        public async Task<Arrange> GetArrangeByIdAsync(int arrangeId)
        {
            var arrange = await httpClient.GetAsync($"api/Arrange/Single-Arrange/{arrangeId}");
            var response = await arrange.Content.ReadFromJsonAsync<Arrange>();
            return response!;
        }

        public async Task<Arrange> UpdateArrangeAsync(Arrange model)
        {
            var arrange = await httpClient.PutAsJsonAsync("api/Arrange/Add-Arrange", model);
            var response = await arrange.Content.ReadFromJsonAsync<Arrange>();
            return response!;
        }
    }
}
