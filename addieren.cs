using System;

namespace Bruchrechner
{
    partial class Main{
        public void Addieren(ref int zähler, ref int zähler1, ref int nenner, ref int nenner1)
        {
            int zählerErgebnis = zähler * nenner1 + zähler1 * nenner;
            int nennerErgebnis = nenner * nenner1;
            Console.WriteLine(zählerErgebnis);
            Console.WriteLine(nennerErgebnis);

        }
    }
}