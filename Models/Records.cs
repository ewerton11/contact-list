using System.ComponentModel.DataAnnotations;

namespace RecordsApi.Models
{
    public class RecordsItem {
        public int Id { get; set; }

        public string? User { get; set; }

        public string? Gender { get; set; }

        public int Age { get; set; }

        public string? Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}