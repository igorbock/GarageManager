using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageManager.Models
{
    [Table("Servicos")]
    public class Servico : ICadastro
    {
        [Key]
        [Browsable(false)]
        public int Id { get; set; }

        [Column("Descricao")]
        [DisplayName("Descrição")]
        [Description("Descrição do serviço oferecido")]
        [Required(ErrorMessage = "O campo \"Descrição\" é obrigatório.")]
        public string Descricao { get; set; }

        [Column("ValorBase")]
        [DisplayName("Valor Base (R$)")]
        [Description("Valor base cobrado pelo serviço")]
        public decimal ValorBase { get; set; }

        [Column("TempoEstimado")]
        [DisplayName("Tempo Estimado (min)")]
        [Description("Tempo estimado de execução em minutos")]
        public int TempoEstimado { get; set; }

        [Browsable(false)]
        public string DisplayText => Descricao;

        public override string ToString() => Descricao ?? string.Empty;
    }
}
