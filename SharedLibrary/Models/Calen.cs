namespace SharedLibrary.Models
{
    public class Calen
    {
        public int Id { get; set; } // 每個時段的唯一識別碼
        public int Bed { get; set; } // 床位，0 表示 A 床，1 表示 B 床
        public DateTime Day { get; set; } // 時段的日期
        public TimeSlot Slott { get; set; } // 時段，上午或下午
        public bool  IsReserved { get; set; } // 是否已預約

        // 外鍵屬性參考 Arrange 表中的 Id 屬性
        public int ArrangeId { get; set; }
        public Arrange? Arrange { get; set; } // 導覽屬性，表示 Calen 與 Arrange 的關聯

        public enum TimeSlot
        {
            Morning,
            Afternoon
        }
    }


}

