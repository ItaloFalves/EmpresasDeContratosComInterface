using AutomatizacaoDeContratos.Entities;
using AutomatizacaoDeContratos.Services;
using System;
using System.Diagnostics.Contracts;

namespace AutomatizacaoDeContratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do contrato: ");
            Console.Write("Numero do contrato: ");
            int numContrato = int.Parse(Console.ReadLine());
            Console.Write("Data do contrato: (dd/MM/yyyy)");
            DateTime dataContrato = DateTime.Parse(Console.ReadLine());
            Console.Write("Valor do contrato: ");
            double valorContrato = double.Parse(Console.ReadLine());
            Console.Write("Numero de meses para parcelamento do contrato: ");
            int numParcelamento = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numContrato, dataContrato, valorContrato);
            ContratoService contratoService = new ContratoService(new PayPalService());
            contratoService.ProcessaContrato(contrato, numParcelamento);
     
            Console.WriteLine("Parcelas: ");
            foreach (Parcela parcelas in contrato.Parcelas)
            {
                Console.WriteLine(parcelas);
            }

            Console.ReadLine();
        }
    }
}