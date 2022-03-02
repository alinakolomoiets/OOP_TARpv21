using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TARpv21
{
	class Program
	{
		static void Main(string[] args)
		{
			Inimine[] inimised = new Inimine[3];
			for (int i = 0; i < 1; i++)
			{
				inimised[i] = new Inimine();
				Console.WriteLine("Nimi:");
				inimised[i].Eesnimi = Console.ReadLine();
				Console.WriteLine("Vanus:");
				inimised[i].Vanus = int.Parse(Console.ReadLine());
				Console.WriteLine("Pikkus:");
				inimised[i].Pikkus = int.Parse(Console.ReadLine());
			}
			foreach (Inimine inimine in inimised)
			{
				inimine.Tervitame();
			}
			Inimine naine = new Inimine ("Alina",Emakeel.inglise,Sugu.naine);
			naine.Palk = 1000;
			double minutulu=naine.Tulumaks();
			Console.WriteLine("Minu tulumaks on:" + minutulu);

			Inimine mees = new Inimine();
			mees.Eesnimi = "Mati";
			Console.WriteLine("Ma olen {0}", mees.Eesnimi);
			mees.Vanus = int.Parse(Console.ReadLine());
			mees.Tervitame();

			Console.ReadLine();
		}
	}
}
