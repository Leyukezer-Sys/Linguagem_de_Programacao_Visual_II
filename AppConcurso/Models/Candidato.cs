using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppConcurso_v2.Models
{
    [Table("candidato"),PrimaryKey(nameof(Id))]
    public class Candidato
    {
        [Column("id")]
        public int Id { get; }

        [Column("nome")]
        public string? Nome { get; set; }

        [Column("cpf")]
        public string? Cpf { get; set; }

        [Column("data_nascimento")]
        public DateTime? Data_Nasc { get; set; }

        public List<Inscricao>? Inscricoes { get; set; }
    }
}
