namespace ConsoleApplication3
{
    public class Program
    {
        static void Main(String[] args)
        {

            //Anzeige Startspielfeld
            var spielfeld = new string[3, 3];
            spielfeld[0, 0] = "1"; //count!? spielfeld[count] = spielfeld[count]?
            spielfeld[0, 1] = "2"; //Array Folge 1Dimensional
            spielfeld[0, 2] = "3";
            spielfeld[1, 0] = "4";
            spielfeld[1, 1] = "5";
            spielfeld[1, 2] = "6";
            spielfeld[2, 0] = "7";
            spielfeld[2, 1] = "8";
            spielfeld[2, 2] = "9";
            int Spieler = 1;
            Console.WriteLine("Spielfeld:"); //Spielfeld Start
            Console.WriteLine($"{spielfeld[0, 0]} {spielfeld[0, 1]} {spielfeld[0, 2]}");
            Console.WriteLine($"{spielfeld[1, 0]} {spielfeld[1, 1]} {spielfeld[1, 2]}");
            Console.WriteLine($"{spielfeld[2, 0]} {spielfeld[2, 1]} {spielfeld[2, 2]}");
            //Console.WriteLine($"{spielfeld}"); //Systemfehler32 ?
            for (var runde = 0; runde < 9; runde++) // evtl. Problem bei falscheingabe / endlosschleife!?
            {
                //Eingabeaufforderung
                Console.WriteLine($"Spieler {Spieler}: Bitte eine freie Feldnummer wählen + Enter zum bestätigen");
                string auswahlreadline = Console.ReadLine();
                int auswahl = Convert.ToInt32(auswahlreadline);
                //Spielerabfrage per switch mit if auswahl und Spieleränderung ++ --
                //!doppelte auswahl + Continue
                switch (Spieler)
                {
                    case 1:
                        {
                            if (auswahl == 1 && spielfeld[0, 0] == "1") //=cpoyrigth !break !continue
                                spielfeld[0, 0] = "X";
                            if (auswahl == 2 && spielfeld[0, 1] == "2")
                                spielfeld[0, 1] = "X";
                            if (auswahl == 3 && spielfeld[0, 2] == "3")
                                spielfeld[0, 2] = "X";
                            if (auswahl == 4)
                                spielfeld[1, 0] = "X";
                            if (auswahl == 5)
                                spielfeld[1, 1] = "X";
                            if (auswahl == 6)
                                spielfeld[1, 2] = "X";
                            if (auswahl == 7)
                                spielfeld[2, 0] = "X";
                            if (auswahl == 8)
                                spielfeld[2, 1] = "X";
                            if (auswahl == 9)
                                spielfeld[2, 2] = "X";
                            Console.WriteLine("");
                            Spieler++;
                            break;
                        }
                    case 2:
                        {
                            if (auswahl == 1 && spielfeld[0, 0] == "1")
                                spielfeld[0, 0] = "O";
                            if (auswahl == 2 && spielfeld[0, 1] == "2")
                                spielfeld[0, 1] = "O";
                            if (auswahl == 3 && spielfeld[0, 2] == "3")
                                spielfeld[0, 2] = "O";
                            if (auswahl == 4)
                                spielfeld[1, 0] = "O";
                            if (auswahl == 5)
                                spielfeld[1, 1] = "O";
                            if (auswahl == 6)
                                spielfeld[1, 2] = "O";
                            if (auswahl == 7)
                                spielfeld[2, 0] = "O";
                            if (auswahl == 8)
                                spielfeld[2, 1] = "O";
                            if (auswahl == 9)
                                spielfeld[2, 2] = "O";
                            Console.WriteLine("");
                            Spieler--;
                            break;
                        }
                }
                // case Gewinnabfrage + reset || Spielfeldanzeige

                Console.WriteLine("aktuelles Spielfeld:"); //Program.Spielfeld(spielfeld);
                Console.WriteLine($"{spielfeld[0, 0]} {spielfeld[0, 1]} {spielfeld[0, 2]}");
                Console.WriteLine($"{spielfeld[1, 0]} {spielfeld[1, 1]} {spielfeld[1, 2]}");
                Console.WriteLine($"{spielfeld[2, 0]} {spielfeld[2, 1]} {spielfeld[2, 2]}");
                Console.WriteLine("");

                //static void Spielfeld(int spielfeld)
                //{
                //    Console.WriteLine("aktuelles Spielfeld:"); //Spielfeld
                //    Console.WriteLine($"{spielfeld[0,0]} {spielfeld[0,1]} {spielfeld[0,2]}");
                //    Console.WriteLine($"{spielfeld[1,0]} {spielfeld[1,1]} {spielfeld[1,2]}");
                //    Console.WriteLine($"{spielfeld[2,0]} {spielfeld[2,1]} {spielfeld[2,2]}");
                //    Console.WriteLine("");
                //}
            }

        }
        //public int Gameplay(string input)
        //{

        //    if (input == "1")
        //        {
        //            Console.WriteLine("input 1");
        //        }
        //        if (input == "1")
        //        {
        //            Console.WriteLine("input 2");
        //        }
        //    //iff spieler 1 x
        //    //else spieler 2 o
        //    //return spielstand;
        //}

    }
}