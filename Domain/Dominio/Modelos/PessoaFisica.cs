using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.Interfaces;

namespace Dominio.Modelos
{
    [Table("pessoa_fisica")]
    public class PessoaFisica : IEntidade
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required]
        [MaxLength(11)]
        [Column("cpf")]
        public string Cpf { get; set; }

        [Required]
        [Column("data_nascimento")]
        public DateTime DataNascimento { get; set; }

        [MaxLength(30)]
        [Column("sexo")]
        public string Sexo { get; set; }

        [MaxLength(30)]
        [Column("estado_civil")]
        public string EstadoCivil { get; set; }

        [MaxLength(30)]
        [Column("nacionalidade")]
        public string Nacionalidade { get; set; }

        [Column("id_pessoa")]
        public long? IdPessoa { get; set; }
    }
}
