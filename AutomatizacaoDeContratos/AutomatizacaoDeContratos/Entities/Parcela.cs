
namespace AutomatizacaoDeContratos.Entities
{
    class Parcela
    {
        public DateTime DataContrato { get; set; }
        public double Valor { get; set; }

        public Parcela(DateTime dataContrato, double valor)
        {
            DataContrato = dataContrato;
            Valor = valor;
        }

        public override string ToString()
        {
            return DataContrato.ToString("dd/MM/yyyy")
                + " - "
                + Valor.ToString("F2");
        }

    }
}
