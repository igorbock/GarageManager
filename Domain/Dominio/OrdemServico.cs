using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    [Table("OrdemServico")]
    public class OrdemServico
    {

        public OrdemServico()
        {
            Pecas_servico = new List<Peca>();
        }

        [Key]
        public int Id { get; set; }

        [MaxLength(10)]
        public string HoraInicio { get; set; }

        [MaxLength(10)]
        public string DataInicio { get; set; }

        [MaxLength(10)]
        public string HoraFim { get; set; }

        [MaxLength(10)]
        public string DataFim { get; set; }

        [MaxLength(7)]
        [Required]
        public string Placa_veiculo { get; set; }

        [MaxLength(100)]
        public string Modelo_veiculo { get; set; }

        [MaxLength(30)]
        public string Cor_veiculo { get; set; }

        [MaxLength(20)]
        public string Ano_veiculo { get; set; }

        [MaxLength(10)]
        public string Km_veiculo { get; set; }

        [MaxLength(100)]
        [Required]
        public string Nome_cliente { get; set; }

        [MaxLength(30)]
        [Required]
        public string Telefone_cliente { get; set; }

        [MaxLength(500)]
        public string Servicos_esperados { get; set; }

        [MaxLength(500)]
        public string Servicos_realizados { get; set; }
        
        [MaxLength(50)]
        public string Mecanico { get; set; }

        [MaxLength(20)]
        public string Status { get; set; }

        public bool Lavacao { get; set; }

        public virtual List<Peca> Pecas_servico { get; set; }

        [MaxLength(500)]
        public string Pagamento { get; set; }
    }
}
