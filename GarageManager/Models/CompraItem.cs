using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageManager.Models
{
    [Table("compra_item")]
    public class CompraItem
    {
        [Key]
        public int Id { get; set; }

        [Column("id_compra")]
        public int IdCompra { get; set; }

        [Column("id_produto")]
        public int IdProduto { get; set; }

        [Column("quantidade")]
        public int Quantidade { get; set; }

        [Column("custo_unitario")]
        public decimal CustoUnitario { get; set; }
    }
}
