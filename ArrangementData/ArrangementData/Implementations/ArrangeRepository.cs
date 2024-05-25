//using SharedLibrary.ArrangeRepositories;
//using ArrangementData.Data;
//using SharedLibrary.Models;
//using Microsoft.EntityFrameworkCore;
//using static SharedLibrary.Models.Arrange;

//namespace ArrangementData.Implementions
//{
//    public class ArrangeRepository : IArrangeRepository
//    {
//        private readonly AppDbContext appDbContext;

//        public ArrangeRepository(AppDbContext appDbContext)
//        {
//            this.appDbContext = appDbContext;
//        }

//        public async Task<Arrange> AddArrangeAsync(Arrange model)
//        {
//            if (model is null) return null!;
//            var chk = await appDbContext.Arranges.Where(_ => _.Patient_Id.ToLower().Equals(model.Patient_Id.ToLower())).FirstOrDefaultAsync();
//            if (chk is not null) return null!;

//            var newDataAdded = appDbContext.Arranges.Add(model).Entity;
//            await appDbContext.SaveChangesAsync();
//            return newDataAdded;
//        }

//        public async Task<Arrange> DeleteArrangeAsync(int arrangeId)
//        {
//            var arrange = await appDbContext.Arranges.FirstOrDefaultAsync(_ => _.Id == arrangeId);
//            if (arrange is null) return null!;
//            appDbContext.Arranges.Remove(arrange);
//            await appDbContext.SaveChangesAsync();
//            return arrange;
//        }

//        public async Task<List<Arrange>> GetAllArrangesAsync() => await appDbContext.Arranges.ToListAsync();
//        //public async Task<List<Arrange>> GetArrangementAsync(string Bed_Id, DateTime Date, TimeSlot Slot, bool IsReserved, string Patient_Id) => await appDbContext.Arranges.ToListAsync();


//        public async Task<Arrange> GetArrangeByIdAsync(int arrangeId)
//        {
//            var arrange = await appDbContext.Arranges.FirstOrDefaultAsync(_ => _.Id == arrangeId);
//            if (arrange is null) return null!;
//            return arrange;
//        }
//        //public async Task<IEnumerable<Arrange>> GetArrangementAsync(string Bed_Id, DateTime Date, TimeSlot Slot, bool IsReserved, string Patient_Id)
//        //{
//        //    var query = appDbContext.Arranges.AsQueryable();  // 创建一个可查询对象，表示 Arrange 表中的所有数据
//        //    if (!string.IsNullOrEmpty(Bed_Id))
//        //    {
//        //        query = query.Where(a => a.Bed_Id == Bed_Id);  // 如果 Bed_Id 不为空，则过滤 Bed_Id 匹配的记录
//        //    }
//        //}
//        public async Task<IEnumerable<Arrange>> GetArrangementAsync(string Bed_Id, DateTime Date, TimeSlot Slot, bool IsReserved, string Patient_Id)
//        {
//            var query = appDbContext.Arranges.AsQueryable();

//            if (!string.IsNullOrEmpty(Bed_Id))
//            {
//                query = query.Where(a => a.Bed_Id == Bed_Id);
//            }

//            if (Date != default(DateTime))
//            {
//                query = query.Where(a => a.Date == Date);
//            }

//            if (Slot != default(TimeSlot))
//            {
//                query = query.Where(a => a.Slot == Slot);
//            }

//            if (IsReserved)
//            {
//                query = query.Where(a => a.IsReserved == IsReserved);
//            }

//            if (!string.IsNullOrEmpty(Patient_Id))
//            {
//                query = query.Where(a => a.Patient_Id == Patient_Id);
//            }

//            return await query.ToListAsync();
//        }

//        public async Task<Arrange> UpdateArrangeAsync(Arrange model)
//        {
//            var arrange = await appDbContext.Arranges.FirstOrDefaultAsync(_ => _.Id == model.Id);
//            if (arrange is null) return null!;
//            arrange.Nursing_station = model.Nursing_station;
//            arrange.Bed_Id = model.Bed_Id;
//            arrange.Date = model.Date;
//            arrange.Patient_Id = model.Patient_Id;
//            arrange.Slot = model.Slot;
//            arrange.Operator = model.Operator;
//            arrange.Operating_time = model.Operating_time;

//            return await appDbContext.Arranges.FirstOrDefaultAsync(_ => _.Id == model.Id)!;
//        }
//    }
//}