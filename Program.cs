using System;

namespace Coffee
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coffee coffee = new Coffee();
            Coffee blackcoffee = new BlackCoffee();
            Coffee latte = new Latte();
            Coffee cortado = new Cortado();

            //System.Console.WriteLine("Prisen for kaffe er: " + coffee.Price() + " kr.");
            System.Console.WriteLine("Prisen for sort kaffe er: " + blackcoffee.Price() + " kr.");
            System.Console.WriteLine(blackcoffee);
            System.Console.WriteLine();
            System.Console.WriteLine("Prisen for latte er: " + latte.Price() + " kr.");
            System.Console.WriteLine(latte);
            System.Console.WriteLine();
            System.Console.WriteLine("Prisen for cortado er: " + cortado.Price() + " kr.");
            System.Console.WriteLine(cortado);
            System.Console.WriteLine();
            

        }
    }
}
