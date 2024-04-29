using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.Models
{
    public class Arrange
    {
        public int Id { get; set; }
        public string Nursing_station { get; set; } = string.Empty;
        [Required]
        public string Bed_Id { get; set; } = string.Empty ;
        [Required]
        public string? Patient_Id { get; set; } = string.Empty;
        [Required]
        public DateTime? Date { get; set; }
        public TimeSlot? Slot { get; set; }
        public string? Operator { get; set; } = string.Empty;
        public DateTime Operating_time { get; set; }

        public Arrange()
        {
            Operating_time = DateTime.Now;
            Date = DateTime.Now;
        }

        public enum TimeSlot
        {
            Morning,
            Afternoon
        }

    }

}