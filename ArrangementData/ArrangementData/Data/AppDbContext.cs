using Microsoft.EntityFrameworkCore;
using SharedLibrary.Models;

namespace ArrangementData.Data
{
    public class AppDbContext : DbContext
    {
   
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }

        public DbSet<Arrange> Arranges { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var reservations = new List<Reservation>();
            var startDate = new DateTime(2024, 5, 27);
            var endDate = new DateTime(2024, 6, 5);
            var bedIds = new[] { "A", "B" };
            var slots = new[] { "上午", "下午" };

            int id = 1;

            foreach (var bedId in bedIds)
            {
                foreach (var date in EachDay(startDate, endDate))
                {
                    foreach (var slot in slots)
                    {
                        reservations.Add(new Reservation
                        {
                            Id = id++,
                            BedId = bedId,
                            Day = date,
                            SlOt = slot,
                            // 其他字段可以設置為默認值
                        });
                    }
                }
            }

            modelBuilder.Entity<Reservation>().HasData(reservations);
        }

        private IEnumerable<DateTime> EachDay(DateTime from, DateTime to)
        {
            for (var day = from.Date; day <= to; day = day.AddDays(1))
                yield return day;
        }
    }
}
