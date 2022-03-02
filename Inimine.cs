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
		int pikkus;
		Emakeel emakeel;
		Sugu sugu;
		int palk;

		public Inimine() { }  //конструктор
		public Inimine(string Eesnimi, Emakeel emakeel)
		{
			eesnimi = Eesnimi;
			this.emakeel = emakeel;
			vanus = Vanus;
		}
		public Emakeel Emakeel 
		{
			get { return emakeel; }
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
			get {
				var staatus = "";
				if (vanus < 7)
				{
					staatus = "väike laps";
				}
				else if (vanus < 17)
				{
					staatus = "kooli laps";
				}
				else if (vanus < 65)
				{
					staatus = "tööline inimine";
				}
				else
				{ staatus = "senior"; }
				return staatus;
			}
		}
		public int Pikkus {
			set {
				pikkus = value;
				if (pikkus < 160)
				{
					staatus = "alla keskmise";
				}
				else if (pikkus < 175)
				{
					staatus = "keskmine pikkus";
				}
				else if (pikkus < 190)
				{
					staatus = "kõrge pikkus";
				}
				else
				{
					staatus = "Ogo";
				}
			}
		}
		public Sugu Sugu 
		{
			get { return sugu; }
		}
		public void Tervitame()//метод
		{
			Console.WriteLine("Tere!");
			Console.WriteLine("Minu nimi on {0} . Olen {1} aastat vana . Minu staatus on {3} . Minu pikkus on {3} .Ma olen {4} .", eesnimi, vanus,pikkus, Staatus,sugu );
		}
		public int Palk 
		{
			set { palk = value; }
			get { return palk; }
		}
		public double Tulumaks()
		{
			double tulu = 0;
			tulu = palk * 0.2;
			return tulu;
		}
	}  

}
