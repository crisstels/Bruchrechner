using System;

namespace Bruchrechner
{
    partial class Main{
        /* Multipliziert 2 Brüche miteinander */
        public void Multiplikation(Bruch bruch1, Bruch bruch2)
        {
            int zählerErgebnis = bruch1.zähler *  bruch2.zähler ;
            int nennerErgebnis = bruch1.nenner * bruch2.nenner;
            Console.WriteLine(zählerErgebnis + "/" + nennerErgebnis);
        }
    }
}