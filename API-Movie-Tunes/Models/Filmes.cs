using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Movie_Tunes.Models
{
    [Table("Filmes")]
    public class Filmes
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Sinopse { get; set; }
        [Required]
        public DateTime AnoLancamento { get; set; }
        [Required]
        public Classificacoes Classificação { get; set; }
        [Required]
        public ICollection<TrilhasSonoras> TrilhaSonoras { get; set; }


    }

    public enum Classificacoes
    {
        Otimo,
        Bom,
        Regular,
        Ruim,
        Pessimo
    }

}
