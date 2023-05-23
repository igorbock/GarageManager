namespace GarageManagerRazorLib.DTOs;

public class OrdemServicoDTO
{
    public int Id { get; set; }
    public DateTime? Inicio { get; set; }
    public DateTime? Fim { get; set; }
    public string? Esperados { get; set; }
    public string? Realizados { get; set; }
    public string? Mecanico { get; set; }
    public int Status { get; set; }
    public bool Lavacao { get; set; }
    public string? Pagamento { get; set; }
    public int IdVeiculo { get; set; }
    public string? Veiculo { get; set; }
    public int IdCliente { get; set; }
    public string? Cliente { get; set; }
    public string? Telefone { get; set; }
}
