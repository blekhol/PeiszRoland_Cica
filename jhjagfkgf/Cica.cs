using System;
using System.Linq;

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
		int rendetlensegSzintMax;
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
			rendetlensegSzintMax = 100;
			if (szin == "narancssárga")
			{
				rendetlensegSzintMax += 20;
			}
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
			rendetlensegSzint = rendetlensegSzintMax;
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
				rendetlensegSzint += 10;
			} while (rendetlensegSzint < rendetlensegSzintMax);
		}

		public void Orgedes()
		{
			kor++;
			rendetlensegSzintMax -= 10;
		}

		public void Szeretgetes()
		{
			Console.WriteLine($"{nev}-t szeretgetik");
			rendetlensegSzint -= 5;
			if (rendetlensegSzint < 0) rendetlensegSzint = 0;
		}


		public void Felfedezes()
		{
			Console.WriteLine($"{nev} felfedez");
			rendetlensegSzint -= 10;
			suly -= 1;
			if (rendetlensegSzint < 0) rendetlensegSzint = 0;
		}

		public void Nyavogas()
		{
			Console.WriteLine($"{nev} nyávog");
			rendetlensegSzint += 5;
		}

		public void Futas()
		{
			Console.WriteLine($"{nev} fut");
			suly -= 2;
			rendetlensegSzint += 5;
		}

		public void Karmolas()
		{
			Console.WriteLine($"{nev} megkarmolt");
			rendetlensegSzint += 15;
		}
	}
}
