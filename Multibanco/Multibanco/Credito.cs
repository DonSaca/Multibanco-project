using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multibanco
{
    public class Credito
    {
        public double ValorCredito { get; private set; }
        public bool Aprovado { get; set; }
        public bool Pago { get; private set; }
        public double Abatimento { get; private set; }

        public Credito(double valorCredito)
        {
            ValorCredito = valorCredito;
            Aprovado = false;
            Pago = false;
            Abatimento = 0;
        }

        public void Abater(double valor)
        {
            if (Abatimento + valor > ValorCredito)
            {
                throw new InvalidOperationException("Abatimento excede o valor do credito");
            }
            Abatimento += valor;

            if (Abatimento == ValorCredito)
            {
                Pago = true;
            }
        }
    }

    

}
