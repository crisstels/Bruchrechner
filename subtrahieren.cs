using System;

namespace Bruchrechner
{
    partial class Main{
        /* Subtrahiert Bruch 1 von Bruch 2*/
        public void Subtraktion(Bruch bruch1, Bruch bruch2, ref Bruch ergebnis)
        {
            ergebnis.zaehler = bruch1.zaehler * bruch2.nenner - bruch2.zaehler * bruch1.nenner;
            ergebnis.nenner = bruch1.nenner * bruch2.nenner;
        }
    }
}