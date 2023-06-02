namespace GarageManagerRazorLib.Models;

[Table("marcas", Schema = "oficina")]
public class Marca : IEntidade
{
    public Marca() { }

    public Marca(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }

    [Key]
    public int Id { get; set; }
    [MaxLength(50)]
    public string? Nome { get; set; }
}
