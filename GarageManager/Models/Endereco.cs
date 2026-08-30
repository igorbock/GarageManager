using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GarageManager.Controls;

namespace GarageManager.Models
{
    [Table("endereco")]
    public class Endereco : ICadastro
    {
        [Key]
        [Browsable(false)]
        public int Id { get; set; }

        [Column("rua")]
        [DisplayName("Rua")]
        [Required(ErrorMessage = "O campo \"Rua\" é obrigatório.")]
        public string Rua { get; set; }

        [Column("numero")]
        [DisplayName("Número")]
        [Required(ErrorMessage = "O campo \"Número\" é obrigatório.")]
        public int Numero { get; set; }

        [Column("cep")]
        [DisplayName("CEP")]
        [Required(ErrorMessage = "O campo \"CEP\" é obrigatório.")]
        public string Cep { get; set; }

        [Column("bairro")]
        [DisplayName("Bairro")]
        public string Bairro { get; set; }

        [Column("id_cidade")]
        [DisplayName("Cidade")]
        [TypeConverter(typeof(ForeignKeyConverter<Cidade>))]
        [Required(ErrorMessage = "O campo \"Cidade\" é obrigatório.")]
        public int IdCidade { get; set; }

        [Browsable(false)]
        public string DisplayText => $"{Rua}, {Numero}";

        public override string ToString() => DisplayText ?? string.Empty;
    }
}
