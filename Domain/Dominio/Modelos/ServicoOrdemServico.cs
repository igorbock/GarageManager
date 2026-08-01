using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.Interfaces;

namespace Dominio.Modelos
{
    [Table("servico_ordem_servico")]
    public class ServicoOrdemServico : IEntidade
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required]
        [Column("id_servico")]
        public long IdServico { get; set; }

        [Required]
        [Column("id_ordem_servico")]
        public long IdOrdemServico { get; set; }

        [Required]
        [Column("id_funcionario")]
        public long IdFuncionario { get; set; }

        [Column("valor", TypeName = "decimal(15,4)")]
        public decimal? Valor { get; set; }
    }
}
