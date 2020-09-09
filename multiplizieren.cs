using System;

namespace Bruchrechner
{
    partial class Main{
        /* Multipliziert 2 Brüche miteinander */
        public void Multiplikation(Bruch bruch1, Bruch bruch2, ref Bruch ergebnis)
        {
            ergebnis.zaehler = bruch1.zaehler *  bruch2.zaehler ;
            ergebnis.nenner = bruch1.nenner * bruch2.nenner;
        }
    }
}