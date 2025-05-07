using System.ComponentModel.DataAnnotations.Schema;

namespace AppMulta.Models
{
    [Table("multa")]
    public class Multa
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("descricao")]
        public string? Descricao { get; set; }

        [Column("valor_multa")]
        public double? Valor { get; set; }

        [Column("id_veiculo")]
        public int IdVeiculo { get; set; }

        [ForeignKey(nameof(IdVeiculo))]
        public Veiculo? Veiculo { get; set; }
    }
}
