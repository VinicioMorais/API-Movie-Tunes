using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Movie_Tunes.Models
{
    [Table("TrilhasSonoras")]
    public class TrilhasSonoras
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public DateTime AnoLancamento { get; set; }
        [Required]
        public int TrilhasSonorasId { get; set; }
        public TrilhasSonoras TrilhaSonoras { get; set; }
    }
}
