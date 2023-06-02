namespace GarageManagerRazorLib.Models;

[Table("veiculos", Schema = "oficina")]
public class Veiculo : IEntidade
{
    [Key]
    public int Id { get; set; }
    [MaxLength(7)]
    [Required]
    public string? Placa { get; set; }
    [MaxLength(30)]
    public string? Cor { get; set; }
    public int? Ano { get; set; }
    public decimal? Km { get; set; }
    [ForeignKey(nameof(Modelo))]
    public int IdModelo { get; set; }
    public virtual Modelo? Modelo { get; set; }
}
