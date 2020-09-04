using System;

namespace Bruchrechner
{
    class Program
    {
        /* Hauptprogramm des Bruchrechners */
        static void Main(string[] args)
        {
            Main rechnen = new Main();
            Bruch bruch1 = new Bruch();
            Bruch bruch2 = new Bruch();

            rechnen.Bruch_EingabeFormat();

            rechnen.Bruch_eingeben(ref bruch1, ref bruch2);

            Console.WriteLine("Zähler: " + bruch1.zähler);
            
            rechnen.Addition(bruch1, bruch2);
            rechnen.Subtraktion(bruch1, bruch2);
            rechnen.Multiplikation(bruch1, bruch2);
            rechnen.Division(bruch1, bruch2);

            Console.ReadKey(true);
        }
    }
}
