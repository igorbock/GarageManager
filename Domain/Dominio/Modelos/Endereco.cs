using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.Interfaces;

namespace Dominio.Modelos
{
    [Table("endereco")]
    public class Endereco : IEntidade
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("rua")]
        public string Rua { get; set; }

        [Required]
        [Column("numero")]
        public int Numero { get; set; }

        [Required]
        [MaxLength(8)]
        [Column("cep")]
        public string Cep { get; set; }

        [MaxLength(50)]
        [Column("bairro")]
        public string Bairro { get; set; }

        [Required]
        [Column("id_cidade")]
        public long IdCidade { get; set; }
    }
}
