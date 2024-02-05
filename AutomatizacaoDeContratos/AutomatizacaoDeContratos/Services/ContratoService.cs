
using AutomatizacaoDeContratos.Entities;

namespace AutomatizacaoDeContratos.Services
{
    class ContratoService
    {

        private IPagamentoOnlineService _pagamentoOnlineService;

        public ContratoService(IPagamentoOnlineService pagamentoOnlineService)
        {
            _pagamentoOnlineService = pagamentoOnlineService;
        }

        public void ProcessaContrato(Contrato contrato, int meses)
        {
            double cota = contrato.ValorContrato / meses;
            for (int i = 1; i <= meses; i++)
            {
                DateTime date = contrato.DataContrato.AddMonths(i);
                double atualizarCota = cota + _pagamentoOnlineService.TaxaMes(i, cota);
                double totalCota = atualizarCota + _pagamentoOnlineService.PagamentoTaxa(atualizarCota);
                contrato.AdicionarParcela(new Parcela(date, totalCota));
            }
        }
    }
}
