using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.Interfaces;

namespace Dominio.Modelos
{
    [Table("empresa")]
    public class Empresa : IEntidade
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("nome")]
        public string Nome { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("razao_social")]
        public string RazaoSocial { get; set; }

        [Required]
        [MaxLength(14)]
        [Column("cnpj")]
        public string Cnpj { get; set; }

        [Required]
        [Column("guid_empresa")]
        public Guid GuidEmpresa { get; set; }

        [MaxLength(200)]
        [Column("endereco")]
        public string Endereco { get; set; }

        [MaxLength(30)]
        [Column("cidade")]
        public string Cidade { get; set; }

        [MaxLength(2)]
        [Column("uf")]
        public string Uf { get; set; }

        [Column("id_empresa_matriz")]
        public long? IdEmpresaMatriz { get; set; }
    }
}
