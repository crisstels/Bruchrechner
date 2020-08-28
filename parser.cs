using System;

namespace Bruchrechner
{
    partial class Main{
        /* Überprüft, ob die Eingabe des Users vom Typ Int32 ist */
        public bool überprüfeEingabe(int zahl){

            Type check = zahl.GetType();

            return check.Equals(typeof(int));

        }

    }
}