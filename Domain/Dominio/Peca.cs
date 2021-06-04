using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    [Table("Pecas")]
    public class Peca
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Descricao_peca { get; set; }

        [MaxLength(50)]
        public string Marca_peca { get; set; }

        [Range(-9999999999.999, 9999999999.999)]
        [Required]
        public decimal Quantidade_peca { get; set; }

        [Range(-9999999999.999, 9999999999.999)]
        [Required]
        public decimal Valor_peca { get; set; }

        [MaxLength(20)]
        public string Valor_total { get; set; }

        [ForeignKey("OrdemServico")]
        public int OrdemServicoId { get; set; }

        public virtual OrdemServico OrdemServico { get; set; }
    }
}
