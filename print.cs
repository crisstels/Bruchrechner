using System;

namespace Bruchrechner
{
    partial class Main{

        /* Gibt Daten auf der Konsole aus */

        public int Menu(){
            Console.WriteLine("Welche Operation möchten Sie ausführen? Drücken Sie die");
            Console.WriteLine("1 für Addition (+)");
            Console.WriteLine("2 für Subtraktion (-)");
            Console.WriteLine("3 für Multiplikation (*)");
            Console.WriteLine("4 für Division (/)");
            Console.WriteLine("5 um das Programm zu beenden");
            int op = Convert.ToInt32(Console.ReadLine());

            return op;
        }

        public void Bruch_EingabeFormat(){
            Console.WriteLine("Bitte geben Sie zwei Brüche ein!");
            Console.WriteLine("Eingabeformat:");
            Console.WriteLine("A    C");
            Console.WriteLine("-    -");
            Console.WriteLine("B    D");
        }

        public void Bruch_eingeben(ref Bruch bruch1, ref Bruch bruch2){
            Console.WriteLine("A = ");
            bruch1.zähler = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B = ");
            bruch1.nenner = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C = ");
            bruch2.zähler = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("D = ");
            bruch2.nenner = Convert.ToInt32(Console.ReadLine());
        }

        public void Ergebnis_ausgeben(Bruch ergebnis){
            Console.WriteLine(ergebnis.zähler + "/" + ergebnis.nenner);
        }

    }
}