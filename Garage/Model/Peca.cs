using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Garage.Model
{
    [Table("Pecas")]
    class Peca
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public String Descricao_peca { get; set; }

        [MaxLength(50)]
        public String Marca_peca { get; set; }

        [Range(9999999999.999, 9999999999.999)]
        [Required]
        public decimal Quantidade_peca { get; set; }

        [Range(9999999999.999, 9999999999.999)]
        [Required]
        public decimal Valor_peca { get; set; }

        [ForeignKey("OrdemServico")]
        public int OrdemServicoId { get; set; }

        public virtual OrdemServico OrdemServico { get; set; }
    }
}
