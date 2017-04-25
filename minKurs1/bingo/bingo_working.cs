using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bingo
{
    class GetUserNrs

    {
        public static int[] GetUserGuesses()
        {
            int userNr = 0;
            int[] UserBingoNrs = new int[10]; // Skapa en vektor för att spara 10 st inmatade tal.
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
            int random = 0; // skapa en tillfälling varibel för att hålla random nr.
            int correctCount = 0; // Skapa en variabel för att hålla koll på antal rätt.
            int[] RandomNrs = new int[7]; // Skapa en vektor med 7 nr för bingon.
            Random rnd = new Random();
            for (int i = 0; i < RandomNrs.Length; i++) // For loop för att slumpa fram 7 st nummer, samt kontrollerar om en siffra redan
                                                       // finns i vektorn.
            {
                random = rnd.Next(1, 25); 
                if (!RandomNrs.Contains(random)) // OM vektorn RandomNrs [] INTE redan innehåller det slumpade talet.
                {
                    RandomNrs[i] = random; // Lägg till talet till vektorn.
                    if (UserBingoNrs.Contains(RandomNrs[i])) // OM sats för att kolla om några av UserNrs är samma som RandomNr? Dvs antal rätt.
                    {
                        correctCount++; // räknar antal rätt
                    }
                }
                else // ANNARS SÅ om det slumpade talet redan finns i vektorn, dra bort 1 tal och kör om loopen.
                {
                    i--;   
                }
            }


            Console.WriteLine("User nrs: \n [{0}]", string.Join(", ", UserBingoNrs)); // Skriv ut användarens tal.
            Console.WriteLine("Random nrs: \n [{0}]", string.Join(", ", RandomNrs)); // Skriv ut bingo tal.
            Console.WriteLine("Du fick: " + correctCount + "poäng"); // Skriv ut antal rätt.
            return UserBingoNrs; // återgå till Main metoden
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till bingo spelet, skriv in 10 tal mellan 1 och 25 ");
            GetUserNrs.GetUserGuesses(); // Anropar klassen GetUserNrs och metoden GetUserGuesses.
            Console.ReadKey(); // Slut
        }
    }
}











