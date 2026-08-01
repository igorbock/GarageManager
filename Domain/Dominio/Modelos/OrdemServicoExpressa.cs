using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.Interfaces;

namespace Dominio.Modelos
{
    [Table("ordem_servico_expressa")]
    public class OrdemServicoExpressa : IEntidade
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required]
        [Column("data_inicio")]
        public DateTime DataInicio { get; set; }

        [Required]
        [Column("data_fim")]
        public DateTime DataFim { get; set; }

        [Required]
        [Column("hora_inicio")]
        public TimeSpan HoraInicio { get; set; }

        [Column("hora_fim")]
        public TimeSpan? HoraFim { get; set; }

        [MaxLength(7)]
        [Column("placa")]
        public string Placa { get; set; }

        [Column("kilometragem")]
        public long? Kilometragem { get; set; }

        [MaxLength(100)]
        [Column("veiculo")]
        public string Veiculo { get; set; }

        [MaxLength(30)]
        [Column("cor")]
        public string Cor { get; set; }

        [Column("ano")]
        public int? Ano { get; set; }

        [MaxLength(100)]
        [Column("nome_cliente")]
        public string NomeCliente { get; set; }

        [MaxLength(100)]
        [Column("telefone")]
        public string Telefone { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }
    }
}
