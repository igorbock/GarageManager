using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageManager.Models
{
    [Table("funcionario")]
    public class Funcionario : ICadastro
    {
        [Key]
        public int Id { get; set; }

        [Column("carga_horaria_semanal")]
        [DisplayName("Carga Horária Semanal")]
        [Required(ErrorMessage = "O campo \"Carga Horária\" é obrigatório.")]
        public int CargaHorariaSemanal { get; set; } = 44;

        [Column("id_pessoa")]
        [DisplayName("Pessoa")]
        [TypeConverter(typeof(GarageManager.Controls.ForeignKeyConverter<Pessoa>))]
        [Required(ErrorMessage = "O campo \"Pessoa\" é obrigatório.")]
        public int IdPessoa { get; set; }

        [Column("id_empresa")]
        [DisplayName("Empresa")]
        [Browsable(false)]
        public int IdEmpresa { get; set; }

        [Browsable(false)]
        public string DisplayText
        {
            get
            {
                try
                {
                    var pessoa = new Data.Repository<Pessoa>().GetById(IdPessoa);
                    if (pessoa != null && !string.IsNullOrWhiteSpace(pessoa.Nome))
                        return pessoa.Nome;
                }
                catch { }
                return $"Funcionario #{Id}";
            }
        }

        public override string ToString() => DisplayText ?? string.Empty;
    }
}
