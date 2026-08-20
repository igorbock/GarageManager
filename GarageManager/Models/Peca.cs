namespace GarageManager.Models
{
    public class Peca
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