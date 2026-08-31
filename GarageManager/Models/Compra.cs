using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageManager.Models
{
    [Table("compra")]
    public class Compra : ICadastro
    {
        [Key]
        [Browsable(false)]
        public int Id { get; set; }

        [Column("data")]
        [DisplayName("Data")]
        [Browsable(false)]
        public string Data { get; set; } = DateTime.UtcNow.ToString("o");

        [Column("id_fornecedor")]
        [DisplayName("Fornecedor")]
        public int? IdFornecedor { get; set; }

        [Column("id_empresa")]
        [Browsable(false)]
        public int IdEmpresa { get; set; }

        [Column("total")]
        [DisplayName("Total (R$)")]
        [Browsable(false)]
        public decimal Total { get; set; }

        [Column("status")]
        [DisplayName("Status")]
        public string Status { get; set; } = "ABERTA";

        [Column("observacao")]
        [DisplayName("Observação")]
        public string Observacao { get; set; }

        [Browsable(false)]
        public string DisplayText => $"Compra #{Id} {Status}";

        public override string ToString() => DisplayText ?? string.Empty;
    }
}
