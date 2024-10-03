using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multibanco
{
    public static class Generic
    {
        public static List<conta> ListaContas = new List<conta>();
        public static conta admin = new conta("0000", "admin", 999999, "0000", true);
        public static conta CurrentAccount = new conta();

       

    }
}
