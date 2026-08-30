using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GarageManager.Controls;

namespace GarageManager.Models
{
    [Table("produto")]
    public class Produto : ICadastro
    {
        [Key]
        [Browsable(false)]
        public int Id { get; set; }

        [Column("id_marca")]
        [DisplayName("Marca")]
        [TypeConverter(typeof(ForeignKeyConverter<Marca>))]
        [Required(ErrorMessage = "O campo \"Marca\" é obrigatório.")]
        public int IdMarca { get; set; }

        [Column("nome")]
        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo \"Nome\" é obrigatório.")]
        public string Nome { get; set; }

        [Column("preco_venda")]
        [DisplayName("Preço Venda (R$)")]
        public decimal PrecoVenda { get; set; }

        [Column("estoque_minimo")]
        [DisplayName("Estoque Mínimo")]
        public int EstoqueMinimo { get; set; } = 5;

        [Browsable(false)]
        public string DisplayText => Nome;

        public override string ToString() => Nome ?? string.Empty;
    }
}
