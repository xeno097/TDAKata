using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp61.Exceptions;

namespace ConsoleApp61
{
	public class LifeGame
	{
		/*
		 *		1. Any live cell with fewer than two live neighbours dies, as if caused by underpopulation.
				2. Any live cell with more than three live neighbours dies, as if by overcrowding.
				3. Any live cell with two or three live neighbours lives on to the next generation.
				4. Any dead cell with exactly three live neighbours becomes a live cell.
		 * 
		 * 
		 * 
		 **/


		int rows;
		int colunms;
		char[,] grid;

		public LifeGame(int _rows, int _colunms)
		{
			this.rows = _rows;
			this.colunms = _colunms;
			this.grid = new char[_rows, _colunms];
		}

		public void SetCell(char cell,int x, int y)
		{
			this.grid[x, y] = cell;
		}

		private bool getCell(int x,int y)
		{
			if (x > rows || y > colunms)
			{
				return false;
			}

			return true;
		}

		private char GetCell(int x,int y)
		{
			if (!this.getCell(x, y))
			{
				throw new CellOutOfBoundsException();
			}

			return this.grid[x, y];
		}

		private bool GetN(int x,int y)
		{
			int cnt = 0;

			for(int i = x - 1; i <= x + 1; i++)
			{
				for(int j = y - 1; j <= y + 1; j++)
				{
					if (i == x && j == y) continue;

					char check = GetCell(i, j);
					if (check == '*') cnt++;
				}
			}

			if (cnt < 2)
			{
				return false;
			}
			else if (cnt > 3)
			{
				return false;
			}
			if (GetCell(x, y) == '.' && cnt == 3) //controlla
			{
				return true;
			}


			return true;
		}


		public void Game()
		{

			char[,] temp = new char[rows, colunms];

			for(int x = 0; x < this.rows; x++)
			{
				for(int y = 0; y < this.colunms; y++)
				{
					bool n = GetN(x, y);

					if (n)
					{
						temp[x, y] = '*';
					}
					else
					{
						temp[x, y] = '.';
					}
				}
			}

			this.grid = temp;
		}


		

	}
}
