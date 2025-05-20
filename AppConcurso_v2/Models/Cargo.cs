using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppConcurso_v2.Models
{
    [Table("cargo"), PrimaryKey(nameof(Id))]
    public class Cargo
    {
        [Column("id")]
        public int Id { get; }

        [Column("nome_cargo")]
        public string? Nome { get; set; }

        [Column("edital")]
        public string? Edital { get; set; }

        [Column("salario_base")]
        public decimal? Salario { get; set; }

        public List<Inscricao>? Inscricoes { get; set; }
    }
}
