using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp61
{
	class Program
	{
		static void Main(string[] args)
		{
			string line;

			Console.WriteLine("Insert number of rows of the grid: ");
			int rows = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Insert number of colunms of the grid: ");
			int colunms = Convert.ToInt32(Console.ReadLine());

			LifeGame lifeGame = new LifeGame(rows, colunms);

			for(int i = 0; i < rows; i++)
			{
				line = Console.ReadLine();
				int j = 0;
				foreach (char c in line)
				{
					
					lifeGame.SetCell(c, i, j);
					j++;
				}
				
			}

			lifeGame.Game();

			


		}
	}
}
