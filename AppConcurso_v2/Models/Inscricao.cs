using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppConcurso_v2.Models
{
    [Table("inscricao"), PrimaryKey(nameof(Id))]
    public class Inscricao
    {
        [Column("id")]
        public int Id { get; }

        [Column("numero_insc")]
        public string? Numero { get; set; }

        [Column("data_insc")]
        public DateTime? Data_Inscricao { get; set; }

        [Column("nota_conh_gerais")]
        public decimal? Nota_Conh_Gerais { get; set; }

        [Column("nota_conh_especificos")]
        public decimal? Nota_Conh_Especificos { get; set; }

        [Column("candidato_id")]
        public int Id_Candidato { get; set; }

        [Column("cargo_id")]
        public int Id_Cargo { get; set; }

        [ForeignKey(nameof(Id_Candidato))]
        public Candidato? Candidato { get; set; }

        [ForeignKey(nameof(Id_Cargo))]
        public Cargo? Cargo { get; set; }
    }
}
