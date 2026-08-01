using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.Interfaces;

namespace Dominio.Modelos
{
    [Table("pessoa_fisica_empresa")]
    public class PessoaFisicaEmpresa : IEntidade
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required]
        [Column("id_pessoa_fisica")]
        public long IdPessoaFisica { get; set; }

        [Required]
        [Column("id_empresa")]
        public long IdEmpresa { get; set; }
    }
}
