namespace GarageManager.Models
{
    public class OrdemServico
    {
        public int Id { get; set; }

        public string HoraInicio { get; set; }

        public string DataInicio { get; set; }

        public string HoraFim { get; set; }

        public string DataFim { get; set; }

        public string Placa_veiculo { get; set; }

        public string Modelo_veiculo { get; set; }

        public string Cor_veiculo { get; set; }

        public string Ano_veiculo { get; set; }

        public string Km_veiculo { get; set; }

        public string Nome_cliente { get; set; }

        public string Telefone_cliente { get; set; }

        public string Servicos_esperados { get; set; }

        public string Servicos_realizados { get; set; }

        public string Mecanico { get; set; }

        public int? Mecanico_id { get; set; }

        public string Status { get; set; }

        public bool Lavacao { get; set; }

        public string Pagamento { get; set; }
    }
}