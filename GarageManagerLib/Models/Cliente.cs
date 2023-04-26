﻿namespace GarageManagerLib.Models;

[Table("clientes", Schema = "oficina")]
public class Cliente
{
    [Key]
    public int Id { get; set; }
    [MaxLength(100)]
    public string? Nome { get; set; }
    [MaxLength(20)]
    public string? Telefone { get; set; }
    public string? CPF { get; set; }
}
