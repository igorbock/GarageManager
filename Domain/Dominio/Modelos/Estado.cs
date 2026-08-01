using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.Interfaces;

namespace Dominio.Modelos
{
    [Table("estado")]
    public class Estado : IEntidade
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("nome")]
        public string Nome { get; set; }

        [Required]
        [MaxLength(2)]
        [Column("sigla")]
        public string Sigla { get; set; }

        [Required]
        [Column("codigo_ibge")]
        public int CodigoIBGE { get; set; }
    }
}
