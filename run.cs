using System;

namespace Bruchrechner
{
    partial class Main
    {
        /* Programmablauf des Bruchrechners. Läuft solange bis der User das Programm beendet. */
        
        public void run(ref Bruch bruch1, ref Bruch bruch2, ref Bruch ergebnis){
            Main rechnen = new Main();

            rechnen.Splash();

            while (true){

            int op = rechnen.Menu();
            if(op == 5){
                break;
            }
            rechnen.Bruch_EingabeFormat();
            rechnen.Bruch_eingeben(ref bruch1, ref bruch2);
            rechnen.Bruch_ausgeben(bruch1, bruch2);

            switch(op){
                case 1:
                    rechnen.Addition(bruch1, bruch2, ref ergebnis);
                    break;
                case 2:
                    rechnen.Subtraktion(bruch1, bruch2, ref ergebnis);
                    break;
                case 3:
                    rechnen.Multiplikation(bruch1, bruch2, ref ergebnis);
                    break;
                case 4:
                    rechnen.Division(bruch1, bruch2, ref ergebnis);
                    break;
                default:
                    Console.WriteLine("Wrong operator");
                    break;
            }

            rechnen.kürzen(ref ergebnis);
            rechnen.Ergebnis_ausgeben(ergebnis);
            Console.ReadKey(true);

            }
        }


    }
}