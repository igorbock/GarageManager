using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageLib.Models
{
    [Table("veiculo")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(7)]
        [Required]
        public string Placa { get; set; }

        [MaxLength(30)]
        public string Cor { get; set; }

        public int? Ano { get; set; }

        public decimal? Km { get; set; }

        [ForeignKey(nameof(Modelo))]
        public int IdModelo { get; set; }

        public virtual Modelo Modelo { get; set; }

        [NotMapped]
        public string Nome { get; set; }
    }
}
