
namespace AutomatizacaoDeContratos.Services
{
    class PayPalService : IPagamentoOnlineService
    {
        private const double PorcentagemTaxa = 0.02;
        private const double JurosMensal = 0.01;

        public double TaxaMes(int meses, double quantia)
        {
            return quantia * JurosMensal * meses;
        }

        public double PagamentoTaxa(double quantia)
        {
            return quantia * PorcentagemTaxa;
        }
    }
}
