using SharedLibrary.ArrangeRepositories;
using ArrangementData.Data;
using SharedLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Implementations
{
    public class ArrangeRepository : IArrangeRepository
    {
        private readonly AppDbContext appDbContext;

        public ArrangeRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Arrange> AddArrangeAsync(Arrange model)
        {
           // if (model is null) return null!;
           // var chk = await appDbContext.Arranges.Where(_ => _.Patient_Id.ToLower().Equals(model.Patient_Id.ToLower())).FirstOrDefaultAsync();
           // if (chk is not null) return null!;

            var newDataAdded = appDbContext.Arranges.Add(model).Entity;
            await appDbContext.SaveChangesAsync();
            return newDataAdded;
        }

        public async Task<Arrange> DeleteArrangeAsync(int arrangeId)
        {
            var arrange = await appDbContext.Arranges.FirstOrDefaultAsync(_ => _.Id == arrangeId);
            if (arrange is null) return null!;
            appDbContext.Arranges.Remove(arrange);
            await appDbContext.SaveChangesAsync();
            return arrange;
        }

        public async Task<List<Arrange>> GetAllArrangesAsync() => await appDbContext.Arranges.ToListAsync();

        public async Task<Arrange> GetArrangeByIdAsync(int arrangeId)
        {
            var arrange = await appDbContext.Arranges.FirstOrDefaultAsync(_ => _.Id == arrangeId);
            if (arrange is null) return null!;
            return arrange;
        }

        public async Task<Arrange> UpdateArrangeAsync(Arrange model)
        {
            var arrange = await appDbContext.Arranges.FirstOrDefaultAsync(_ => _.Id == model.Id);
            if (arrange is null) return null!;
            arrange.Nursing_station = model.Nursing_station;
            arrange.Bed_Id = model.Bed_Id;
            arrange.Date = model.Date;
            arrange.Patient_Id = model.Patient_Id;
            arrange.Slot = model.Slot;
            arrange.Operator = model.Operator;
            arrange.Operating_time = model.Operating_time;

            return await appDbContext.Arranges.FirstOrDefaultAsync(_ => _.Id == model.Id)!;
        }
    }
}