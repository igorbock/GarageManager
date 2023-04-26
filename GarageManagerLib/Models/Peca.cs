﻿namespace GarageManagerLib.Models;

[Table("pecas", Schema = "oficina")]
public class Peca
{
    [Key]
    public int Id { get; set; }
    public string? Descricao { get; set; }
    public string? Marca { get; set; }
    public decimal Quantidade { get; set; }
    public decimal Valor { get; set; }
}