using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GarageManager.Controls;

namespace GarageManager.Models
{
    [Table("usuario")]
    public class Usuario : ICadastro
    {
        [Key]
        public int Id { get; set; }

        [Column("hash")]
        [DisplayName("Hash")]
        [Required(ErrorMessage = "O campo \"Hash\" é obrigatório.")]
        [Browsable(false)]
        public string Hash { get; set; }

        [Column("inativo")]
        [DisplayName("Inativo")]
        public int Inativo { get; set; }

        [Column("id_colaborador")]
        [DisplayName("Funcionário")]
        [TypeConverter(typeof(ForeignKeyConverter<Funcionario>))]
        [Required(ErrorMessage = "O campo \"Funcionário\" é obrigatório.")]
        public int IdColaborador { get; set; }

        [Browsable(false)]
        public string DisplayText => $"Usuario #{Id}";

        public override string ToString() => DisplayText ?? string.Empty;
    }
}
