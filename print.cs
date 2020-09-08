using System;
// ฅ^•ﻌ•^ฅ
// ٩ʕ•͡×•ʔ۶
namespace Bruchrechner
{
    partial class Main{
        /* Gibt Daten oder Informationen auf der Konsole aus */

        public void Intro(){
            Console.WriteLine("          _________ ");
            Console.WriteLine("         | ________ |");
            Console.WriteLine("         ||12345678||");
            Console.WriteLine("         |----------|");
            Console.WriteLine("         |[M|#|C][-]|");
            Console.WriteLine("         |[7|8|9][+]|");
            Console.WriteLine("         |[4|5|6][x]|");
            Console.WriteLine("         |[1|2|3][%]|");
            Console.WriteLine("         |[.|O|:][=]|");
            Console.WriteLine("          _________ ");

        }
        public void Splash(){
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++" + "\n");
            Console.WriteLine("Titel: Bruchrechner");
            Console.WriteLine("Beschreibung: Einfacher Bruchrechner, welcher 2 Brüche miteinander verrechnet und das Ergebnis kürzt.");
            Console.WriteLine("Autor: Natalie Hasselmann  ʕ•ᴥ•ʔ");
            Intro();
            Console.WriteLine("\n" + "Drücken Sie eine beliebige Taste zum fortfahren" + "\n");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++" + "\n");
            Console.ReadKey(true);
        }
        public int Menu(){
            Console.WriteLine("Welche Operation möchten Sie ausführen? Drücken Sie die");
            Console.WriteLine("1 für Addition (+)");
            Console.WriteLine("2 für Subtraktion (-)");
            Console.WriteLine("3 für Multiplikation (*)");
            Console.WriteLine("4 für Division (/)");
            Console.WriteLine("5 um das Programm zu beenden" + "\n");
            int op = Convert.ToInt32(Console.ReadLine());

            return op;
        }

        public void Bruch_EingabeFormat(){
            Console.WriteLine("Bitte geben Sie zwei Brüche ein!");
            Console.WriteLine("Eingabeformat:");
            Console.WriteLine("A    C");
            Console.WriteLine("-  , -");
            Console.WriteLine("B    D" + "\n");
        }

        public void Bruch_eingeben(ref Bruch bruch1, ref Bruch bruch2){
            Console.WriteLine("A = " + "\t");
            bruch1.zähler = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B = ");
            bruch1.nenner = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C = ");
            bruch2.zähler = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("D = ");
            bruch2.nenner = Convert.ToInt32(Console.ReadLine());
        }

        public void Bruch_ausgeben(Bruch bruch1, Bruch bruch2){
            Console.WriteLine("Sie haben folgende Brüche eingegeben: ");            
            Console.WriteLine(bruch1.zähler + "    " + bruch2.zähler);
            Console.WriteLine("-  , -");
            Console.WriteLine(bruch1.nenner + "    " + bruch2.nenner + "\n");
            

        }

        public void Ergebnis_ausgeben(Bruch ergebnis){
            Console.WriteLine("Ergebnis: ");
            Console.WriteLine(ergebnis.zähler);
            Console.WriteLine("-");
            Console.WriteLine(ergebnis.nenner + "\n");
        }

    }
}