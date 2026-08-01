using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.Interfaces;

namespace Dominio.Modelos
{
    [Table("ordem_servico")]
    public class OrdemServico : IEntidade
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Required]
        [Column("data_inicio")]
        public DateTime DataInicio { get; set; }

        [Column("data_fim")]
        public DateTime? DataFim { get; set; }

        [Required]
        [Column("hora_inicio")]
        public TimeSpan HoraInicio { get; set; }

        [Column("hora_fim")]
        public TimeSpan? HoraFim { get; set; }

        [Required]
        [MaxLength(7)]
        [Column("placa")]
        public string Placa { get; set; }

        [MaxLength(30)]
        [Column("cor")]
        public string Cor { get; set; }

        [Column("ano")]
        public int? Ano { get; set; }

        [Required]
        [Column("kilometragem")]
        public long Kilometragem { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Required]
        [Column("id_cliente")]
        public long IdCliente { get; set; }

        [Required]
        [Column("id_modelo")]
        public long IdModelo { get; set; }

        [Column("id_ordem_expressa")]
        public long? IdOrdemExpressa { get; set; }

        [Column("lavacao")]
        public bool Lavacao { get; set; }
    }
}
