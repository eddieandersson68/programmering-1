using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppdrag_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // användaren skriver in sitt förnamn
            Console.WriteLine("Skriv in ditt förnamn ! ");
            string surName = Console.ReadLine(); // använaderens förnamn sparad i strängvariablen "surName".

            // användaren skriver in sitt efternamn
            Console.WriteLine("Skriv in ditt efternamn ! ");
            string lastName = Console.ReadLine(); // använaderens förnamn sparad i strängvariablen "lastName".

            // anvbändaren skriver in sin ålder. 
            Console.Write("Hur gammal är du? ");
            string str = Console.ReadLine(); // använaderens ålder sparad i strängvariablen "str".

            int age = Convert.ToInt32(str); // strängvariablen "str" konverteras till int-variabeln "age".
            int pension = 65; //pensions ålder

            // antal år kvar till pension räknas ut genom att dra av värdet för variablen age från variablen pension.
            int yearsLeft = pension - age;

            // Så länge som användarens uppgivna ålder understiger eller är lika med 65 år, händer detta.
            while (age < 65) 
            {
                Console.WriteLine("Hej " + surName + " " + lastName + "!" + " Det är nu " + yearsLeft + " år kvar tills du går i pension.");
                break;
            }
            
            // om användarens ålder är högre eller lika med 65 år händer detta. 
            if (age >= 65)
            {
                Console.WriteLine("Hej " + surName + " " + lastName + "!" + " Grattis till pensionen. :) ");
            }
            Console.ReadKey();


        }
    }
}
