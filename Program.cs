using System;

namespace Bruchrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Main bruch = new Main();
            int zähler1 = 3;
            int nenner1 = 4;
            int zähler2 = 1;
            int nenner2 = 2;
            bruch.Addieren(ref zähler1,ref zähler2,ref nenner1 ,ref nenner2 );
            Console.ReadKey(true);
        }
    }
}
