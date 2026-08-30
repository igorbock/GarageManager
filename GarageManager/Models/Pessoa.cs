using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageManager.Models
{
    [Table("pessoa")]
    public class Pessoa : ICadastro
    {
        [Key]
        [Browsable(false)]
        public int Id { get; set; }

        [Column("nome")]
        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo \"Nome\" é obrigatório.")]
        public string Nome { get; set; }

        [Column("telefone")]
        [DisplayName("Telefone")]
        public string Telefone { get; set; }

        [Column("email")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Column("documento")]
        [DisplayName("CPF/CNPJ")]
        public string Documento { get; set; }

        [Column("tipo_documento")]
        [DisplayName("Tipo Documento")]
        public string TipoDocumento { get; set; }

        [Column("data_cadastro")]
        [DisplayName("Data Cadastro")]
        [Browsable(false)]
        public string DataCadastro { get; set; }

        [Column("id_endereco")]
        [DisplayName("Endereço Id")]
        [Browsable(false)]
        public int? IdEndereco { get; set; }

        [Browsable(false)]
        public string DisplayText => Nome;

        public override string ToString() => Nome ?? string.Empty;
    }
}
