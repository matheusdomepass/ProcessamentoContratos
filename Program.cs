using System;
using System.Globalization;
using ProcessamentoContratos.Entidades;
using ProcessamentoContratos.Servicos;

namespace ProcesssamentoContratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter com os dados do contrato: ");
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do contrato: ");
            double valorContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe qual o numero de parcelas: ");
            int meses = int.Parse(Console.ReadLine());
            
            Contrato contrato = new Contrato(numero, data, valorContrato);

            ServicoContrato servicoContrato = new ServicoContrato(new ServicoPaypal());
            servicoContrato.ProcessarContrato(contrato, meses);

            Console.WriteLine("Parcelas: ");
            foreach (Parcela parcela in contrato.Parcelas)
            {
                Console.WriteLine(parcela);
            }
        }
    }
}