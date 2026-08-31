using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageManager.Models
{
    [Table("estado")]
    public class Estado : ICadastro
    {
        [Key]
        public int Id { get; set; }

        [Column("nome")]
        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo \"Nome\" é obrigatório.")]
        public string Nome { get; set; }

        [Column("sigla")]
        [DisplayName("Sigla")]
        [Required(ErrorMessage = "O campo \"Sigla\" é obrigatório.")]
        public string Sigla { get; set; }

        [Column("codigo_ibge")]
        [DisplayName("Código IBGE")]
        [Required(ErrorMessage = "O campo \"Código IBGE\" é obrigatório.")]
        public int CodigoIbge { get; set; }

        [Browsable(false)]
        public string DisplayText => $"{Nome} ({Sigla})";

        public override string ToString() => DisplayText ?? string.Empty;
    }
}
