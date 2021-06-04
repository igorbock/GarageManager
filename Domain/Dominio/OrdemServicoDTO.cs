namespace Dominio
{
    public class OrdemServicoDTO
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public string Nome_cliente { get; set; }
        public string Placa_veiculo { get; set; }
        public string Modelo_veiculo { get; set; }
        public string Cor_veiculo { get; set; }
        public string Ano_veiculo { get; set; }
        public string Status { get; set; }
    }
}
