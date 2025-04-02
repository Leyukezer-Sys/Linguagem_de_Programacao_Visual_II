namespace BlazorAppIMC.Models
{
    public class CalculadoraIMC
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public double? Peso { get; set; }

        public double? Altura { get; set; }

        public double? CalcularImc()
        {
            return Peso/(Altura * Altura);
        }

        public string? Situacao()
        {
            string? result = null;

            if (CalcularImc() > 29) return result = "obesidade";

            if (CalcularImc() > 24) return result = "sobrepeso";

            if (CalcularImc() > 18.4) return result = "peso normal";

            if (CalcularImc() < 18.5) return result = "peso abaixo do normal";

            return result;
        }
    }
}
