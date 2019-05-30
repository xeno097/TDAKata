using System;
using System.Text;

namespace ConsoleApp63
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the directory of your game_of_life.txt file");
            string dir = Console.ReadLine();

            Game_of_life game = new Game_of_life(dir);

            game.play();
            game.printgrid();


        }
    }
}
