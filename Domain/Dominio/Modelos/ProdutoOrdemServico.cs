using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.Interfaces;

namespace Dominio.Modelos
{
    [Table("produto_ordem_servico")]
    public class ProdutoOrdemServico : IEntidade
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required]
        [Column("id_produto")]
        public long IdProduto { get; set; }

        [Required]
        [Column("id_ordem_servico")]
        public long IdOrdemServico { get; set; }
    }
}
