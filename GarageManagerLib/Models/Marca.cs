namespace GarageManagerLib.Models;

[Table("marcas", Schema = "oficina")]
public class Marca : IEntidade
{
    [Key]
    public int Id { get; set; }
    [MaxLength(50)]
    public string? Nome { get; set; }
}
