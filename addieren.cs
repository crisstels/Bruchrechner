using System;

namespace Bruchrechner
{
    partial class Main{
        /* Addiert 2 Brüche miteinander*/
        public void Addition(Bruch bruch1, Bruch bruch2)
        {
            int zählerErgebnis = bruch1.zähler * bruch2.nenner + bruch2.zähler * bruch1.nenner;
            int nennerErgebnis = bruch1.nenner * bruch2.nenner;
            Console.WriteLine(zählerErgebnis + "/" + nennerErgebnis);
        }
    }
}