using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.Interfaces;

namespace Dominio.Modelos
{
    [Table("servico")]
    public class Servico : IEntidade
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [MaxLength(100)]
        [Column("nome")]
        public string Nome { get; set; }

        [Column("valor", TypeName = "decimal(15,4)")]
        public decimal? Valor { get; set; }
    }
}
