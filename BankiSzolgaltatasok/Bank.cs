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


        public Szamla SzamlaNyitas(Tulajdonos tulajdonos,int hitelkeret)
        {
            if (hitelkeret>0)
            {
                throw new ArgumentException("A hitelkeret ne legyen nulla!");
            }
            else if(hitelkeret ==0)
            {
                Szamla szamla = new MegtakaritasiSzamla(tulajdonos);
                szamlaLista.Add(szamla);
                return szamla;
            }
            else
            {
                Szamla szamla = new HitelSzamla(tulajdonos, hitelkeret);
                szamlaLista.Add(szamla);
                return szamla;
            }
        }

        public long GetOsszEgyenleg(Tulajdonos tulajdonos)
        {
            return szamlaLista.FindAll(x => x.Tulajdonos == tulajdonos).Sum(y => y.AktualisEgyenleg);
        }

        public Szamla GetLegnagyobbEgyenleguSzamla(Tulajdonos tulajdonos)
        {
            return szamlaLista.FindAll(x => x.Tulajdonos == tulajdonos).Find(x => x.AktualisEgyenleg == szamlaLista.FindAll(x => x.Tulajdonos == tulajdonos).Max(x => x.AktualisEgyenleg))!;
        }
        public long OsszHitelkeret
        {
            get
            {
                return szamlaLista.FindAll(x => x is HitelSzamla).Sum(x => (x as HitelSzamla).HitelKeret);
            }
        }

    }
}
