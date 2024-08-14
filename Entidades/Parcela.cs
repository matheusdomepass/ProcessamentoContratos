using System;
using System.Globalization;

namespace ProcessamentoContratos.Entidades
{
    class Parcela
    {
        public DateTime Valor { get; set; }
        public double Quantidade { get; set; }

        public Parcela(DateTime valor, double quantidade)
        {
            Valor = valor;
            Quantidade = quantidade;
        }

        public override string ToString()
        {
            return Valor.ToString("dd/MM/yyyy") +
                " - " +
                Quantidade.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
