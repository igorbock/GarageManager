using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageLib.Models
{
    [Table("modelo")]
    public class Modelo
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; }

        [ForeignKey(nameof(Marca))]
        public int IdMarca { get; set; }

        public virtual Marca Marca { get; set; }
    }
}
