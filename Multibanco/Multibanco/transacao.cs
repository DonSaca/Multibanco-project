using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multibanco
{
    public class transacao
    {
        public double Ordem { get; }
        public string Tipo { get; }
        public DateTime Data { get; }

        public transacao(double ordem, string tipo)
        {
            this.Ordem = ordem;
            this.Tipo = tipo;   
            Data = DateTime.Now;
        }
    }
}
