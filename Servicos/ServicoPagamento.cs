using System;

namespace ProcessamentoContratos.Servicos
{
    interface IServicoPagamento
    {
        double Taxa(double quantidade);
        double Juros(double quantidade, int meses);
    }
}
