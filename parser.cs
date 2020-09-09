using System;

namespace Bruchrechner
{
    partial class Main{
        /* Überprüft, ob die Eingabe des Users vom Typ Int32 ist */
        public bool Ueberpruefe_eingabe(int zahl){

            Type check = zahl.GetType();

            return check.Equals(typeof(int));

        }
        /* Fragt den User solange nach dem Nenner, bis dieser nicht mehr 0 ist.*/
        public void Ueberpruefe_nenner(ref Bruch bruch)
        {
            while (true)
            {
                bruch.nenner = Convert.ToInt32(Console.ReadLine());
                if(bruch.nenner == 0)
                {
                    Console.WriteLine("Der Nenner darf nicht Null sein!");
                    Console.WriteLine("Bitte geben Sie eine andere Zahl ein.");
                }
                else
                {
                    break;
                }
            }
        }

    }
}