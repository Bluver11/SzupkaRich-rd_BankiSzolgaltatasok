using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public class Bank
    {
        private List<Szamla> szamlaLista;

        public Bank(List<Szamla> szamlaLista)
        {
            this.szamlaLista=szamlaLista;
        }



    }
}
