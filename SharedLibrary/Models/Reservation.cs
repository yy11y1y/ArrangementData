using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedLibrary.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string NursingStation { get; set; } = string.Empty;
        [Required(ErrorMessage = "BedId is required.")]
        public string BedId { get; set; } = string.Empty;
        public string PatientId { get; set; } = string.Empty;
        public DateTime Day { get; set; }
        public string SlOt { get; set; } = string.Empty;
        public string OperatOr { get; set; } = string.Empty;
        public DateTime OperatingTime { get; set; }
    }
}