using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avrundning
{
    class Program
    {
        static void Main(string[] args)
        {
      

                // Här ber jag användaren skriva in ett decimal tal.
                Console.WriteLine("Skriv in ett decimaltal, så ska jag avrunda det till så många decimaler som du anger i nästa fråga ");
                string decTal = Console.ReadLine(); //användarens tal lagras i strängvariablen "decTal".

                // Här ber jag användaren skriva in hur många decimaler hens tal ska avrundas till.
                Console.WriteLine("Ange hur många decimaler du vill att ditt tal ska avrundas till ");
                string decimaler = Console.ReadLine(); //Användarens svar lagras i strängvariabeln "decimaler".
                int antal = Convert.ToInt32(decimaler); // strängvariablen "decimaler" konverteras till en Int med namn "antal".
                                                        // Personlig touch på programmet: Skriver ut Tack här är ditt tal avrundat till x antal decimaler :).
                Console.WriteLine("Tack, här är ditt tal avrundat till " + antal + " decimaler :)");

                // Här sker konvertering av strängvariablen "decTal" till en Double som kallas "konverteratTal". 
                double konverteratTal = Convert.ToDouble(decTal);
                // Här skapas svaren kallade "answer" och "answer2" genom att jag rundar av variablen "convertTal"
                // och anger hur många decimaler användaren skrev in före. Samt samma fast med 3 decimaler.
                double svar = Math.Round((Double)konverteratTal, antal);
                double svar2 = Math.Round((Double)konverteratTal, 3);

                Console.WriteLine(svar); // Svaret skrivs ut till användaren.
                Console.WriteLine("Här är ditt tal avrundat till 3 decimaler\n" + svar2); // Svaret skrivs ut till användaren.
                Console.ReadKey();


            }
        }
    }


    

