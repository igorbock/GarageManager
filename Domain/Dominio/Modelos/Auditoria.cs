using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.Interfaces;

namespace Dominio.Modelos
{
    [Table("auditoria")]
    public class Auditoria : IEntidade
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required]
        [MaxLength(6)]
        [Column("metodo")]
        public string Metodo { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("tabela")]
        public string Tabela { get; set; }

        [Required]
        [Column("id_registro")]
        public long IdRegistro { get; set; }

        [Column("antigo")]
        public string Antigo { get; set; }

        [Column("novo")]
        public string Novo { get; set; }

        [Required]
        [Column("id_usuario")]
        public long IdUsuario { get; set; }
    }
}
