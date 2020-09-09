using System;

namespace Bruchrechner
{
    partial class Main{
        /* Dividiert Bruch 1 durch Bruch */
        public void Division(Bruch bruch1, Bruch bruch2, ref Bruch ergebnis)
        {
            ergebnis.zaehler = bruch1.zaehler * bruch2.nenner;
            ergebnis.nenner = bruch1.nenner * bruch2.zaehler;          
        }
    }
}