namespace GarageManagerLib.Models;

[Table("ordens_pecas", Schema = "oficina")]
public class OrdemServicoPecas : IEntidade
{
    [Key]
    public int Id { get; set; }
    [ForeignKey(nameof(OrdemServico))]
    public int IdOrdemServico { get; set; }
    [ForeignKey(nameof(Peca))]
    public int IdPeca { get; set; }
    public virtual OrdemServico? OrdemServico { get; set; }
    public virtual Peca? Peca { get; set; }
    [NotMapped]
    public string? Nome { get; set; }
}
