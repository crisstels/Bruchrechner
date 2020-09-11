using System;
namespace Bruchrechner
{
    /* Gibt Daten oder Informationen auf der Konsole aus */
    partial class Main{

        /* Ein kleines Bild für den Splash-Screen */
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
        /* Der Splash-Screen, welcher wichitge Informationen über das Programm enthält */
        public void Splash(){
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" + "\n");
            Console.WriteLine("Titel: Bruchrechner");
            Console.WriteLine("Beschreibung: Einfacher Bruchrechner, welcher 2 Brüche miteinander verrechnet und das Ergebnis kürzt.");
            Console.WriteLine("Autor: Natalie Hasselmann  ʕ•ᴥ•ʔ");
            Intro();
            Console.WriteLine("\n" + "Drücken Sie eine beliebige Taste zum fortfahren" + "\n");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" + "\n");
            Console.ReadKey(true);
        }
        /* Auswahlmenü für die Rechnungsoperation */
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
        /* Gibt das richtige Eingabeformat des Bruchrechners aus */
        public void Bruch_EingabeFormat(){
            Console.WriteLine("Bitte geben Sie zwei Brüche ein!");
            Console.WriteLine("Eingabeformat:");
            Console.WriteLine("A    C");
            Console.WriteLine("-  , -");
            Console.WriteLine("B    D" + "\n");
        }
        /* Der User gibt die Brüche ein */
        public void Bruch_eingeben(ref Bruch bruch1, ref Bruch bruch2){
            Main rechnen = new Main();

            Console.Write("A = ");
            bruch1.zaehler = Convert.ToInt32(Console.ReadLine());
            Console.Write("B = ");
            rechnen.Ueberpruefe_nenner(ref bruch1);
            Console.Write("C = ");
            bruch2.zaehler = Convert.ToInt32(Console.ReadLine());
            Console.Write("D = ");
            rechnen.Ueberpruefe_nenner(ref bruch2);
        }
        /* Gibt im richtigen Format die Eingabe des Users aus */
        public void Bruch_ausgeben(Bruch bruch1, Bruch bruch2){
            Console.WriteLine("Sie haben folgende Brüche eingegeben: ");            
            Console.WriteLine(bruch1.zaehler + "    " + bruch2.zaehler);
            Console.WriteLine("-  , -");
            Console.WriteLine(bruch1.nenner + "    " + bruch2.nenner + "\n");
            
        }
        /* Gibt das gekürzte Ergebnis aus */
        public void Ergebnis_ausgeben(Bruch ergebnis){
            Console.WriteLine("Ergebnis: ");
            Console.WriteLine(ergebnis.zaehler);
            Console.WriteLine("-");
            Console.WriteLine(ergebnis.nenner + "\n");
            Console.WriteLine("Drücken Sie eine beliebeige Taste zum fortfahren...");
        }

    }
}