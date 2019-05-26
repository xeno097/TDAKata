using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp63
{
    class Game_of_life
    {
        public int rows;
        public int cols;
        char[,] grid;



        public Game_of_life(string dir)
        {
            this.build(dir);   
        }

        private void build(string dir)
        {
            string[] text_game = File.ReadAllLines(dir);
            this.rows = text_game[0][0]-'0';
            this.cols = text_game[0][2]-'0';
            this.grid = new char[this.rows, this.cols];

            for (int i = 0; i < this.rows; i++)
            {
                // S:\Desktop\game_of_life.txt

                string line = text_game[i+1];
                for(int j = 0; j < this.cols; j++)
                {
                    this.grid[i, j] = line[j];
                }
            }
        }


        public void printgrid()
        {
            Console.Write("\n");
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    Console.Write(this.grid[i,j]);
                }
                Console.Write("\n");
            }
        }

        public void play()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int cells = 0;

                    cells += this.getcell(i - 1, j - 1);
                    cells += this.getcell(i, j - 1);
                    cells += this.getcell(i + 1, j - 1);
                    cells += this.getcell(i - 1, j);
                    cells += this.getcell(i + 1, j);
                    cells += this.getcell(i - 1, j + 1);
                    cells += this.getcell(i, j + 1);
                    cells += this.getcell(i + 1, j + 1);


                    if (cells < 2 || cells>3)
                        this.grid[i, j] = '.';
                    else if (cells == 3)
                        this.grid[i, j] = '*';
                }
            }
        }

        private int getcell(int x, int y)
        {
            if (x >= 0 && x < this.rows && y >= 0 && y < this.cols)
                return this.grid[x, y] == '*' ? 1 : 0;

            return 0;
        }


    }
}
