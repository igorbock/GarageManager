using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageManager.Models
{
    [Table("Mecanicos")]
    public class Mecanico : ICadastro
    {
        [Key]
        [Browsable(false)]
        public int Id { get; set; }

        [Column("Nome")]
        [DisplayName("Nome")]
        [Description("Nome completo do mecânico")]
        [Required(ErrorMessage = "O campo \"Nome\" é obrigatório.")]
        public string Nome { get; set; }

        [Column("Especialidade")]
        [DisplayName("Especialidade")]
        [Description("Área de atuação (motor, elétrica, suspensão, etc.)")]
        public string Especialidade { get; set; }

        [Column("Telefone")]
        [DisplayName("Telefone")]
        [Description("Telefone para contato")]
        public string Telefone { get; set; }

        [Column("Ativo")]
        [DisplayName("Ativo")]
        [Description("Se o mecânico está ativo na oficina")]
        public bool Ativo { get; set; } = true;

        [Browsable(false)]
        public string DisplayText => Nome;

        public override string ToString() => Nome ?? string.Empty;
    }
}
