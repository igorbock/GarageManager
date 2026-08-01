using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.Interfaces;

namespace Dominio.Modelos
{
    [Table("cidade")]
    public class Cidade : IEntidade
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required]
        [MaxLength(150)]
        [Column("nome")]
        public string Nome { get; set; }

        [Required]
        [Column("codigo_ibge")]
        public int CodigoIBGE { get; set; }

        [Required]
        [Column("id_estado")]
        public int IdEstado { get; set; }
    }
}
