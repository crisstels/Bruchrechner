using System;

namespace Bruchrechner
{
    partial class Main{
        public void Division(Bruch bruch1, Bruch bruch2)
        {
            int zählerErgebnis = bruch1.zähler * bruch2.nenner;
            int nennerErgebnis = bruch1.nenner * bruch2.zähler;
            Console.WriteLine(zählerErgebnis + "/" + nennerErgebnis);
        }
    }
}