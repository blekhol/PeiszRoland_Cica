using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jhjagfkgf
{
	internal class Cica
	{
		static Random random = new Random();

		private int kor;
		string nev;
		int suly;
		string fajta;
		string szin;
		int rendetlensegSzint;
		int fogyasztas;
		bool ehes;
		string nem;

		public Cica(int kor, string nev, int suly, string fajta, string szin, int rendetlensegSzint, int fogyasztas, string nem)
		{
			this.kor = kor;
			this.nev = nev;
			this.suly = suly;
			this.fajta = fajta;
			this.szin = szin;
			this.rendetlensegSzint = rendetlensegSzint;
			this.fogyasztas = fogyasztas;
			this.nem = nem;
			ehes = true;
		}

		public void Eves(double kajaSuly)
		{
			int esely = random.Next(101);
			ehes = false;
			if (esely <= 4)
			{
				szin = "zöld";
				suly -= (int)(suly * (esely / 100.0));
				rendetlensegSzint /= 2;
			}
			else
			{
				suly += (int)Math.Ceiling(fogyasztas * kajaSuly);
			}


		}
		public void Alvas()
		{
			rendetlensegSzint = 0;

			if (szin == "zöld")
			{
				szin = "Eredeti";
			}
		}

		public void Ebredes()
		{
			rendetlensegSzint = 100;
			ehes = true;
		}

		public void Jatek(string[] jatekok)
		{
			int jatek;

			do
			{
				jatek = random.Next(0, jatekok.Length);
				Console.WriteLine($"Cica tevékenysége: {jatekok[jatek]}");
				if (jatekok[jatek] == "Romlott kaja evése")
				{
					Eves(0.25);
				}

				rendetlensegSzint -= 10;
			} while (rendetlensegSzint - 10 > 0);
		}
	}
}
