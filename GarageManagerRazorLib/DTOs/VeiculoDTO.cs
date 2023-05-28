namespace GarageManagerRazorLib.DTOs;

public class VeiculoDTO
{
    public int Id { get; set; }
    public string? Placa { get; set; }
    public string? Cor { get; set; }
    public int? Ano { get; set; }
    public decimal? Km { get; set; }
    public int IdModelo { get; set; }
    public string? Modelo { get; set; }
    public int IdMarca { get; set; }
    public string? Marca { get; set; }
}
