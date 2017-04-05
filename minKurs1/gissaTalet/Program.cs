using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gissaTalet
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxNr = 100; //Här skapas en konstant heltalsvariabel som heter "maxNr
            // och som får värdet 100. Detta för att kunna variera spelet enkelt senare med andra tal än just 100.
            Random rand = new Random(); // Ett nytt slumptal skapas som kallas för "rand".
            int slumpTal = rand.Next(maxNr) + 1; //
            int tal = 0; // En variabel för talet som användaren kommer att gissa skapas, med värdet 0.
            int gissningar = 0; // En variabel för att hålla reda på antalet gissningar som användaren kommer att behöva skapas, med värdet 0.

            Console.WriteLine("Gissa ett tal mellan 1 och {0} ", maxNr); // Skriver ut till användaren Gissa ett tal mellan 1 och 100.
            do // do...while loppen inleds
            {
                
                
                    Console.WriteLine("Skriv in din gissning: "); // Skriver ut till användaren att denne ska skriva in sin gissning.
                    int.TryParse(Console.ReadLine(), out tal); // Läser av talet användaren skriver in och tilldelar heltalsvariablen tal det värdet.
                    gissningar++; // Räknare för antal gissningar
                
                
                if (tal != slumpTal) // do loopens villkor, om användarens tal är skilt från slumtalet, gör detta.
                {
                    if (tal < slumpTal) // kontrollerar om användarens tal är lägre än slumptalet.
                        Console.WriteLine("\n{0} Det var för litet tal, försök igen ", tal); // Skriver ut till användaren om denne gissat för lågt tal.
                    if (tal > slumpTal) // // kontrollerar om användarens tal är högre än slumptalet.
                        Console.WriteLine("\n{0} Det var för stort tal, försök igen ", tal); // Skriver ut till användaren om denne gissat för högt tal.
                    if (Math.Abs(tal - slumpTal) > 0 && Math.Abs(tal - slumpTal) < 3) // kollar om gissningen var 3 tal ifrån lr ej.
                        Console.WriteLine("Det var nästan rätt tal "); // Skriver ut till användaren om denne gissat nästan rätt (tre tal ifrån).
                }
            }
            while (tal != slumpTal); // hoppar till början av do... while loopen.
            
            {

                Console.WriteLine("Grattis! du gissade rätt tal " + slumpTal + "\nDu gissade " + gissningar + " gånger ");
                Console.ReadLine();
            }
        }
    }
}

