using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.Interfaces;

namespace Dominio.Modelos
{
    [Table("pessoa_juridica_empresa")]
    public class PessoaJuridicaEmpresa : IEntidade
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required]
        [Column("id_pessoa_juridica")]
        public long IdPessoaJuridica { get; set; }

        [Required]
        [Column("id_empresa")]
        public long IdEmpresa { get; set; }
    }
}
