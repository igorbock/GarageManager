using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GarageManager.Controls;

namespace GarageManager.Models
{
    [Table("modelo_veiculo")]
    public class ModeloVeiculo : ICadastro
    {
        [Key]
        public int Id { get; set; }

        [Column("nome")]
        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo \"Nome\" é obrigatório.")]
        public string Nome { get; set; }

        [Column("id_marca")]
        [DisplayName("Marca")]
        [TypeConverter(typeof(ForeignKeyConverter<Marca>))]
        [Required(ErrorMessage = "O campo \"Marca\" é obrigatório.")]
        public int IdMarca { get; set; }

        [Browsable(false)]
        public string DisplayText => Nome;

        public override string ToString() => Nome ?? string.Empty;
    }
}
