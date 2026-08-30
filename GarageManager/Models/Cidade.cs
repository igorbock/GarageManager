using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GarageManager.Controls;

namespace GarageManager.Models
{
    [Table("cidade")]
    public class Cidade : ICadastro
    {
        [Key]
        [Browsable(false)]
        public int Id { get; set; }

        [Column("nome")]
        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo \"Nome\" é obrigatório.")]
        public string Nome { get; set; }

        [Column("codigo_ibge")]
        [DisplayName("Código IBGE")]
        [Required(ErrorMessage = "O campo \"Código IBGE\" é obrigatório.")]
        public int CodigoIbge { get; set; }

        [Column("id_estado")]
        [DisplayName("Estado")]
        [TypeConverter(typeof(ForeignKeyConverter<Estado>))]
        [Required(ErrorMessage = "O campo \"Estado\" é obrigatório.")]
        public int IdEstado { get; set; }

        [Browsable(false)]
        public string DisplayText => Nome;

        public override string ToString() => Nome ?? string.Empty;
    }
}
