using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public abstract class Szamla : BankiSzolgaltatas
	{

		protected int aktualisEgyenleg;

        public Szamla(Tulajdonos tulajdonos) : base(tulajdonos)
		{
			this.aktualisEgyenleg = 0;
		}

		private int AktualisEgyenleg { get => aktualisEgyenleg;}


		public void Befizet(int osszeg)
		{
			this.aktualisEgyenleg += osszeg;
		}

		public abstract bool Kivesz(int osszeg);
        public Kartya UjKartya(string kartyaSzam)
        {
            return new Kartya(this.Tulajdonos,kartyaSzam,this);
        }
    }
}
}
