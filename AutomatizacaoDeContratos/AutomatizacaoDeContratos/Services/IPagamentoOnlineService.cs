
namespace AutomatizacaoDeContratos.Services
{
    interface IPagamentoOnlineService
    {
        public double PagamentoTaxa(double taxa);
        public double TaxaMes(int meses, double quantia);

    }
}
