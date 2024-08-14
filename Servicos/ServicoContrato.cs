using ProcessamentoContratos.Entidades;
using System;


namespace ProcessamentoContratos.Servicos
{
    class ServicoContrato
    {
        private IServicoPagamento _ServicoPagamento;

        public ServicoContrato(IServicoPagamento servicoPagamento)
        {
            _ServicoPagamento = servicoPagamento;
        }

        public void ProcessarContrato(Contrato contrato, int meses)
        {
            double cota = contrato.ValorTotal / meses;
            for (int i = 1; i <= meses; i++)
            {
                DateTime data = contrato.Data.AddMonths(i);
                double aplicacaoCota = cota + _ServicoPagamento.Juros(cota, i);
                double valorTotalCota = aplicacaoCota + _ServicoPagamento.Taxa(aplicacaoCota);
                contrato.AdicionarParcela(new Parcela(data, valorTotalCota));
            }
        }
    }
}
