namespace AppProjetoAluno.Models
{
    public class CalcularNota
    {
        private double? Mediana;
        public int Id { get; set; }

        public string? Name { get; set; }

        public double? Nota1 { get; set; }

        public double? Nota2 { get; set; }

        public CalcularNota(double media)
        {
            Mediana = media;
        }
        public double? Media()
        {
            return (Nota1 + Nota2) / 2;
        }

        public string? Situacao()
        {
            string? result = null;
            if (Media() < Mediana) result = "Abaixo Da Media";
            if (Media() >= Mediana) result = "Aprovado";

            return result;
        }
    }
}
