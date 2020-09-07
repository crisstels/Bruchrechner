using System;

namespace Bruchrechner
{
    partial class Main{
        /* Dividiert Bruch 1 durch Bruch */
        public void Division(Bruch bruch1, Bruch bruch2, ref Bruch ergebnis)
        {
            ergebnis.zähler = bruch1.zähler * bruch2.nenner;
            ergebnis.nenner = bruch1.nenner * bruch2.zähler;          
        }
    }
}