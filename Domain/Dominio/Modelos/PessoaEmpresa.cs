using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.Interfaces;

namespace Dominio.Modelos
{
    [Table("pessoa_empresa")]
    public class PessoaEmpresa : IEntidade
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required]
        [Column("id_pessoa")]
        public long IdPessoa { get; set; }

        [Required]
        [Column("id_empresa")]
        public long IdEmpresa { get; set; }
    }
}
