using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.Interfaces;

namespace Dominio.Modelos
{
    [Table("usuario")]
    public class Usuario : IEntidade
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required]
        [Column("hash")]
        public string Hash { get; set; }

        [Column("inativo")]
        public bool? Inativo { get; set; }

        [Required]
        [Column("id_colaborador")]
        public long IdColaborador { get; set; }
    }
}
