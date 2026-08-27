using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageManager.Models
{
    [Table("Clientes")]
    public class Cliente : ICadastro
    {
        [Key]
        [Browsable(false)]
        public int Id { get; set; }

        [Column("Nome")]
        [DisplayName("Nome")]
        [Description("Nome completo do cliente")]
        [Required(ErrorMessage = "O campo \"Nome\" é obrigatório.")]
        public string Nome { get; set; }

        [Column("Telefone")]
        [DisplayName("Telefone")]
        [Description("Telefone para contato")]
        public string Telefone { get; set; }

        [Column("Email")]
        [DisplayName("E-mail")]
        [Description("Endereço de e-mail")]
        public string Email { get; set; }

        [Column("Endereco")]
        [DisplayName("Endereço")]
        [Description("Endereço completo")]
        public string Endereco { get; set; }

        [Browsable(false)]
        public string DisplayText => Nome;

        public override string ToString() => Nome ?? string.Empty;
    }
}
