using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.Interfaces;

namespace Dominio.Modelos
{
    [Table("usuario_empresa")]
    public class UsuarioEmpresa : IEntidade
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required]
        [Column("id_usuario")]
        public long IdUsuario { get; set; }

        [Required]
        [Column("id_empresa")]
        public long IdEmpresa { get; set; }
    }
}