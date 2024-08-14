using System;

namespace ProcessamentoContratos.Servicos
{
    class ServicoPaypal : IServicoPagamento
    {
        private double TaxaPagamento = 0.02;
        private double JurosMensal = 0.01;

        public double Taxa(double quantidade)
        {
            return quantidade * TaxaPagamento;
        }
        public double Juros(double quantidade, int meses)
        {
            return quantidade * JurosMensal * meses;
        }
    }
}
