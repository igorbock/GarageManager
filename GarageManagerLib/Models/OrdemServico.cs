﻿namespace GarageManagerLib.Models;

[Table("ordem_servico", Schema = "oficina")]
public class OrdemServico
{
    [Key]
    public int Id { get; set; }
    public DateTime? Inicio { get; set; }
    public DateTime? Fim { get; set; }
    [MaxLength(500)]
    public string? Esperados { get; set; }
    [MaxLength(500)]
    public string? Realizados { get; set; }
    [MaxLength(50)]
    public string? Mecanico { get; set; }
    public E_STATUS Status { get; set; }
    public bool? Lavacao { get; set; }
    [MaxLength(500)]
    public string? Pagamento { get; set; }
    [ForeignKey(nameof(Veiculo))]
    public int IdVeiculo { get; set; }
    [ForeignKey(nameof(Cliente))]
    public int IdCliente { get; set; }
    public virtual Veiculo? Veiculo { get; set; }
    public virtual Cliente? Cliente { get; set; }
}