using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.Interfaces;

namespace Dominio.Modelos
{
    [Table("ordem_servico_empresa")]
    public class OrdemServicoEmpresa : IEntidade
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required]
        [Column("id_ordem_servico")]
        public long IdOrdemServico { get; set; }

        [Required]
        [Column("id_empresa")]
        public long IdEmpresa { get; set; }
    }
}
