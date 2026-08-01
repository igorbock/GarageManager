using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.Interfaces;

namespace Dominio.Modelos
{
    [Table("pessoa_juridica")]
    public class PessoaJuridica : IEntidade
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required]
        [MaxLength(14)]
        [Column("cnpj")]
        public string Cnpj { get; set; }

        [MaxLength(20)]
        [Column("inscricao_estadual")]
        public string InscricaoEstadual { get; set; }

        [MaxLength(150)]
        [Column("nome_fantasia")]
        public string NomeFantasia { get; set; }

        [Column("id_pessoa")]
        public long? IdPessoa { get; set; }
    }
}
