using System;

namespace Bruchrechner
{
    partial class Main{
        /* Addiert 2 Brüche miteinander*/
        public void Addition(Bruch bruch1, Bruch bruch2, ref Bruch ergebnis)
        {
            ergebnis.zähler = bruch1.zähler * bruch2.nenner + bruch2.zähler * bruch1.nenner;
            ergebnis.nenner = bruch1.nenner * bruch2.nenner;          
        }
    }
}