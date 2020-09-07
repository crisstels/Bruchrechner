using System;

namespace Bruchrechner
{
    partial class Main{
        /* Multipliziert 2 Brüche miteinander */
        public void Multiplikation(Bruch bruch1, Bruch bruch2, ref Bruch ergebnis)
        {
            ergebnis.zähler = bruch1.zähler *  bruch2.zähler ;
            ergebnis.nenner = bruch1.nenner * bruch2.nenner;
        }
    }
}