using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TARpv21
{
	public class Inimine
	{
		string eesnimi;//поля
		int vanus;
		string staatus;
		//int pikkus;
		Emakeel emakeel;

		public Inimine() { }  //конструктор
		public Inimine(string Eesnimi, Emakeel emakeel)
		{
			eesnimi = Eesnimi;
			this.emakeel = emakeel;
			//vanus = Vanus;
			//staatus = staatus;?
		}
		public Emakeel Emakeel 
		{
			get { return staatus; }
		}
		public string Eesnimi 
		{
			set 
			{
				if (eesnimi == null) eesnimi = value;
			}
			get { return eesnimi;}
		}//свойства
		public int Vanus
		{
			set 
			{ vanus = value;
				if (vanus<7)
				{
					staatus = "väike laps";
				}
				else if (vanus<17)
				{
					staatus = "kooli laps";
				}
				else if (vanus<65)
				{
					staatus = "tööline inimine";
				}
				else
				{
					staatus = "senior";
				}
			}
			get { return vanus; }
		}
		public string Staatus 
		{
			set {if( staatus == null)staatus=value; }
			get { return staatus; }
		}
		//public int Pikkus
		//{
		//	set
		//	{ pikkus = value;
		//		if (pikkus<160)
		//		{
		//			staatus = "alla keskmise";
		//		}
		//		else if (pikkus<175)
		//		{
		//			staatus = "keskmine pikkus";
		//		}
		//		else if (pikkus < 190)
		//		{
		//			staatus = "kõrge pikkus";
		//		}
		//		else
		//		{
		//			staatus = "Ogo";
		//		}
		//	}
		//}
		public void Tervitame()//метод
		{
			Console.WriteLine("Tere!");
			Console.WriteLine("Minu nimi on {0} . Olen {1} aastat vana.Minu staatus on {2} .", eesnimi, vanus, staatus);
		}
	}

}
