

namespace AutomatizacaoDeContratos.Entities
{
    class Contrato
    {
        public int NumeroContrato { get; private set; }
        public DateTime DataContrato { get; private set; }
        public double ValorContrato { get; private set; }
        public List<Parcela> Parcelas { get; set; }

        public Contrato(int numeroContrato, DateTime dataContrato, double valorContrato)
        {
            NumeroContrato = numeroContrato;
            DataContrato = dataContrato;
            ValorContrato = valorContrato;
            Parcelas = new List<Parcela>();
        }

        public void AdicionarParcela(Parcela parcela)
        {
            Parcelas.Add(parcela);
        }
    }
}
