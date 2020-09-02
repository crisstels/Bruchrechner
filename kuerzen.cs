using System;

namespace Bruchrechner
{
    partial class Main{
        /* Sucht den ggt, um einen Bruch zu kürzen */
        public int euklid(int zähler, int nenner)
        {
            if (zähler == 0)
            {
                return nenner;
            }
            else
            {
                while (nenner != 0)
                {
                    if (zähler > nenner)
                    {
                        zähler -= nenner;
                    }
                    else
                    {
                        nenner -= zähler;
                    }
                }
            }
            return zähler;
        }
        /* Kürzt einen Bruch */
        public void kürzen(Bruch ergebnis, int ggT)
        {
            ergebnis.zähler = ergebnis.zähler / ggT;
            ergebnis.nenner = ergebnis.nenner / ggT;
        }
    }
}