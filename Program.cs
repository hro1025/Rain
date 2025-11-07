using System.Diagnostics;
using Spectre.Console.Cli;

namespace Rain;

class Program
{
    static void Main(string[] args)
    {
        while (true) // This place the code into an loop so it possible to run it again
        {
            // This gives output by the program and a input by the user
            Console.WriteLine("Hei!\nRegner det for deg? (Ja eller Nei)");
            string? input = Console.ReadLine();
            if (input == "ja" || input == "Ja")
            {
                Console.WriteLine("Det regner så du bør ta med deg regnjakke og paraply");
                break; // break makes the loop break and stop the application
            }
            else if (input == "nei" || input == "Nei")
            {
                Console.WriteLine("Det regner ikke så du trenger ikke å ta med noe");
                break;
            }
            else // If the user write something else then 'Ja' and 'Nei'. this output will ask the user to try again or exit the program
            {
                Console.WriteLine(
                    "Skriv 'Ja eller Nei'\nHvis du vil prøve på nytt så skriv 'Ja' \nVil du avslutte programmet skriv 'Nei'"
                );
                string? avslutte = Console.ReadLine();

                if (avslutte == "ja" || avslutte == "Ja") { }
                else if (avslutte == "nei" || avslutte == "Nei")
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
