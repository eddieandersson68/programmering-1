using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bingo
{
    
    class GetUserNrs
    {
        public static void ResetArray(int[] x) // Metod för att se till att vektorerna är "nollade"
        {
            for (int i = 0; i > x.Length; i++)
                x[i] = 0;
        }
        public static int[] GetUserGuesses()
        {
            int userNr = 0;
            int[] UserBingoNrs = new int[10]; // Skapa en vektor för att spara 10 st inmatade tal.
            ResetArray(UserBingoNrs); //Kallar på en metod för att se till att vektorn är tom efter varje körning.
            Console.WriteLine("Skriv in dina 10 tal: ");
            for (int i = 0; i < UserBingoNrs.Length; i++) // For loop för att itterera tills alla tal är inskrivna.
            {

                int.TryParse(Console.ReadLine(), out userNr); // Kontrollera att inmatade tal är i intervallet 1-25 och inte ett tecken.
                if (userNr > 0 && userNr < 26)
                {
                    UserBingoNrs[i] = userNr; // Lägg in i vektorn om nr är mellan 1-25.
                }
                else
                {
                    Console.WriteLine("Ditt tal är inte mellan 1-25 eller så slog du in andra tecken ");
                    i--; // Drar bort och gör om inmatningen så att vektorn inte registrar en 0:a.
                }
            }
            bool found = false; // bool för att kontrollera antal rätt senare
            int random = 0; // skapa en tillfälling varibel för att hålla random nr.
            int correctCount = 0; // Skapa en variabel för att hålla koll på antal rätt.
            int[] RandomNrs = new int[7]; // Skapa en vektor med 7 tal för bingon.
            ResetArray(RandomNrs); // Kallar på en metod för att se till att vektorn är tom efter varje körning.
            Random rnd = new Random();
            for (int i = 0; i < RandomNrs.Length; i++) // For loop för att slumpa fram 7 st nummer, samt kontrollerar om en siffra redan
            {                                         // finns i vektorn.
                random = rnd.Next(1, 25); // Slumpa talen.
                for (int s = 0; s < RandomNrs.Length; s++) //loop för att kontrollera att inte samma nr slumpas flera ggr.
                {
                    if (random == RandomNrs[s]) // OM slumpat tal "random" redan finns i RandomNrs vektorn KÖR om loopen.
                    {
                        found = (true);
                    }
                }
                if (found == false) // OM slumpat tal inte finns i RandomNrs redan, lägg till det
                {
                    RandomNrs[i] = random; // Kontroll av antal rätt tal som användaren skrivit in.
                    for (int t = 0; t < UserBingoNrs.Length; t++)
                    {
                        if (random == UserBingoNrs[t])
                        {
                            correctCount++; // Räknare för antal rätt.
                        }
                    }
                }

                if (found == true) //OM om det slumpade talet redan finns i vektorn, dra bort 1 tal och kör om loopen.
                {
                    i--;
                    found = false;
                }
            }
            // Bubblesort för UserBingoNrs.
            int max = UserBingoNrs.Length - 1;
            for (int i = 0; i < max; i++)
            {
                int nrLeft = max - i;
                for (int j = 0; j < nrLeft; j++)
                {
                    if (UserBingoNrs[j] > UserBingoNrs[j + 1])
                    {
                        int temp = UserBingoNrs[j];
                        UserBingoNrs[j] = UserBingoNrs[j + 1];
                        UserBingoNrs[j + 1] = temp;
                    }
                }
            }
            // Bubblesort för RandomNrs
            int maximum = RandomNrs.Length - 1;
            for (int i = 0; i < maximum; i++)
            {
                int nrLeft = maximum - i;
                for (int j = 0; j < nrLeft; j++)
                {
                    if (RandomNrs[j] > RandomNrs[j + 1])
                    {
                        int temp = RandomNrs[j];
                        RandomNrs[j] = RandomNrs[j + 1];
                        RandomNrs[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Dina tal: \n [{0}]", string.Join(", ", UserBingoNrs)); // Skriv ut användarens tal.
            Console.WriteLine("Bingo tal: \n [{0}]", string.Join(", ", RandomNrs)); // Skriv ut bingo tal.
            Console.WriteLine("Grattis du fick: " + correctCount + " poäng"); // Skriv ut antal rätt.
            return UserBingoNrs; // återgå till Main metoden
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till bingo spelet, skriv in 10 tal mellan 1 och 25, avsluta varje inmatning med enter ");
            GetUserNrs.GetUserGuesses(); // Anropar klassen GetUserNrs och metoden GetUserGuesses.
            Console.ReadKey(); // Slut
        }
    }
}











