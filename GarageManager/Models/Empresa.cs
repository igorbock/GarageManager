using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageManager.Models
{
    [Table("empresa")]
    public class Empresa : ICadastro
    {
        [Key]
        public int Id { get; set; }

        [Column("nome")]
        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo \"Nome\" é obrigatório.")]
        public string Nome { get; set; }

        [Column("razao_social")]
        [DisplayName("Razão Social")]
        [Required(ErrorMessage = "O campo \"Razão Social\" é obrigatório.")]
        public string RazaoSocial { get; set; }

        [Column("cnpj")]
        [DisplayName("CNPJ")]
        [Required(ErrorMessage = "O campo \"CNPJ\" é obrigatório.")]
        public string Cnpj { get; set; }

        [Column("guid_empresa")]
        [DisplayName("GUID")]
        [Browsable(false)]
        public string GuidEmpresa { get; set; } = Guid.NewGuid().ToString();

        [Column("endereco")]
        [DisplayName("Endereço")]
        public string Endereco { get; set; }

        [Column("cidade")]
        [DisplayName("Cidade")]
        public string Cidade { get; set; }

        [Column("uf")]
        [DisplayName("UF")]
        public string Uf { get; set; }

        [Column("id_empresa_matriz")]
        [DisplayName("Empresa Matriz Id")]
        [Browsable(false)]
        public int? IdEmpresaMatriz { get; set; }

        [Browsable(false)]
        public string DisplayText => Nome;

        public override string ToString() => Nome ?? string.Empty;
    }
}
