using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class PecaDTO
    {
        public int Id { get; set; }
        public string Descricao_peca { get; set; }
        public string Marca_peca { get; set; }
        public decimal Quantidade_peca { get; set; }
        public decimal Valor_peca { get; set; }
        public string Valor_total { get; set; }
        public int OrdemServicoId { get; set; }
    }
}
