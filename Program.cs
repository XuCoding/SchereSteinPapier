namespace SchereSteinPapier
{

    class Program
    {
        static void Main()
        {
            
            bool weiterspielen = true;
            Random random = new Random(); // Zufallsgenerator Computer

            while (weiterspielen)
            {
                Console.WriteLine("Wähle eine Option: (1) Schere, (2) Stein, (3) Papier");
                string userEingabe = Console.ReadLine();

                int userWahl;

                // Ist die Eingabe gültig?
                if (!int.TryParse(userEingabe, out userWahl) || userWahl < 1 || userWahl > 3)
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte wähle 1, 2 oder 3.");
                    continue;
                }

                // Zufallswahl des Computers (1 = Schere, 2 = Stein, 3 = Papier)
                int computerWahl = random.Next(1, 4);

                // Anzeigen der Wahl des Computers
                string[] optionen = { "Schere", "Stein", "Papier" };
                Console.WriteLine($"Der Computer hat {optionen[computerWahl - 1]} gewählt.");

                // Ergebnis berechnen
                if (userWahl == computerWahl)
                {
                    Console.WriteLine("Unentschieden!");
                }
                else if ((userWahl == 1 && computerWahl == 3) || // Schere schlägt Papier
                         (userWahl == 2 && computerWahl == 1) || // Stein schlägt Schere
                         (userWahl == 3 && computerWahl == 2))   // Papier schlägt Stein
                {
                    Console.WriteLine("Du hast gewonnen!");
                }
                else
                {
                    Console.WriteLine("Du hast verloren!");
                }

                
                Console.WriteLine("Möchtest du eine weitere Runde spielen? (j/n)");
                string antwort = Console.ReadLine().ToLower();

                if (antwort != "j")
                {
                    weiterspielen = false;
                    Console.WriteLine("Danke fürs Spielen!");
                }
            }
        }
    }

}
