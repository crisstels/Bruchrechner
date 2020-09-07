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
            Bruch ergebnis = new Bruch();
            
            rechnen.run(ref bruch1, ref bruch2, ref ergebnis);

            Console.ReadKey(true);
        }
    }
}
