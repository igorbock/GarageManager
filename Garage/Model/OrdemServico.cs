using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Model
{
    [Table("OrdemServico")]
    class OrdemServico
    {
        public OrdemServico()
        {
            Pecas_servico = new List<Peca>();
        }

        [Key]
        public int Id { get; set; }

        [MaxLength(10)]
        public String HoraInicio { get; set; }

        [MaxLength(10)]
        public String DataInicio { get; set; }

        [MaxLength(10)]
        public String HoraFim { get; set; }

        [MaxLength(10)]
        public String DataFim { get; set; }

        [MaxLength(7)]
        [Required]
        public String Placa_veiculo { get; set; }

        [MaxLength(100)]
        public String Modelo_veiculo { get; set; }

        [MaxLength(30)]
        public String Cor_veiculo { get; set; }

        [MaxLength(20)]
        public String Ano_veiculo { get; set; }

        [MaxLength(10)]
        public String Km_veiculo { get; set; }

        [MaxLength(100)]
        [Required]
        public String Nome_cliente { get; set; }

        [MaxLength(30)]
        [Required]
        public String Telefone_cliente { get; set; }

        public virtual IEnumerable<Peca> Pecas_servico { get; set; }
    }
}
