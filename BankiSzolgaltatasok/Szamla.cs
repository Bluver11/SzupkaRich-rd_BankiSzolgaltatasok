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

		public Szamla(Tulajdonos tulajdonos,int aktualisEgyenleg):base(tulajdonos)
		{
			this.aktualisEgyenleg = 0;
		}

		private int AktualisEgyenleg { get => aktualisEgyenleg;}


		public void Befizet(int osszeg)
		{
			this.aktualisEgyenleg += osszeg;
		}

		public abstract bool Kivesz(int osszeg);
	}
}
