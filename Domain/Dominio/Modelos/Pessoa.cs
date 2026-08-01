using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.Interfaces;

namespace Dominio.Modelos
{
    [Table("pessoa")]
    public class Pessoa : IEntidade
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required]
        [MaxLength(150)]
        [Column("nome")]
        public string Nome { get; set; }

        [MaxLength(30)]
        [Column("telefone")]
        public string Telefone { get; set; }

        [MaxLength(100)]
        [Column("email")]
        public string Email { get; set; }

        [Required]
        [Column("data_cadastro")]
        public DateTime DataCadastro { get; set; }

        [Required]
        [Column("id_endereco")]
        public long IdEndereco { get; set; }
    }
}
