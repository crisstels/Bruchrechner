using System;

namespace Bruchrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Main rechnen = new Main();
            Bruch bruch1 = new Bruch();
            Bruch bruch2 = new Bruch();

            bruch1.zähler = 3;
            bruch1.nenner = 4;

            bruch2.zähler = 1;
            bruch2.nenner = 2;
            
            rechnen.Addition(bruch1, bruch2);
            rechnen.Subtraktion(bruch1, bruch2);
            rechnen.Multiplikation(bruch1, bruch2);
            rechnen.Division(bruch1, bruch2);
            Console.ReadKey(true);
        }
    }
}
