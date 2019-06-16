using System;

namespace WordWrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Wrapper wrapper = new Wrapper("Sun Moon Earth", 5);
            Console.WriteLine(wrapper.Wrap());
            Console.WriteLine("Sun  \nMoon \nEarth");

        }
    }
}
