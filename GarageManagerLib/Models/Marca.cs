namespace GarageManagerLib.Models;

[Table("marcas", Schema = "oficina")]
public class Marca
{
    [Key]
    public int Id { get; set; }
    [MaxLength(50)]
    public string? Nome { get; set; }
}
