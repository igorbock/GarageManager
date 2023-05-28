namespace GarageManagerRazorLib.Models;

[Table("modelos", Schema = "oficina")]
public class Modelo : IEntidade
{
    [Key]
    public int Id { get; set; }
    [MaxLength(100)]
    public string? Nome { get; set; }
    [ForeignKey(nameof(Marca))]
    public int IdMarca { get; set; }
    [NotMapped]
    public virtual Marca? Marca { get; set; }
}
