using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amerikanen_I_Bastun
{
    class MyTemperature
    {
        // Metod för att omvandla Farhrenheit till Celcius (float)
        public static float FahrToCels(float fahr)
        {
            return ((fahr - 32.0f) / 9.0f) * 5.0f;

        }
        // Metod för att generera ett slumptal
        public static int GetRandomNr(int slumpTal)
        {

            Random rand = new Random();
            return slumpTal = rand.Next(0, 168);
          
        }
        /* Metod för att läsa in vad användaren skriver och om denne 
         * inte skrivit in ett heltal kasta ett exeption, samt skicka vidare till metoden 
         * för omvandling till Fahrenheit och få tillbaka värdet från den */
        public static float GetTemparatureFromInput()
        {
            float fahrenheit = 0;
            
            try
            {
                return fahrenheit = MyTemperature.FahrToCels(float.Parse(Console.ReadLine()));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fel inmatning det där är inte ett heltal " + ex.Message);
                throw;
            }
        }
        
    }
    class Program
    {   
        public static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till bastun ");
            while (true)
            {
                //int fahrenheit;
                float celsius = 0.0f;
                int slumpTal = 0;
                Console.Write("Skriv in ett tal i Fahrenheit: ");

                /* Läs in Fahrenheit, skicka till metod GetTemparatureFromInput konvertera till ett 
                 * flyttal (float) = fahrenheit och lagra detta i celsius
                */
            try
                {
                    celsius = MyTemperature.GetTemparatureFromInput();
                    slumpTal = MyTemperature.GetRandomNr(slumpTal);
                    
                }
                catch (Exception ex)
                {

                    continue;
                }

                if (celsius == 0)
                {
                    //slumpTal = MyTemperature.GetRandomNr(slumpTal);
                }

                /* värdet på celsius kollas av mot olika villkor och beroende på vilket villkor som
                 * uppfylls, så skrivs respektive text ut till användaren.
                 */
                else if (celsius < 73)
                {
                    Console.WriteLine("Det är inte varm nog, höj temperaturen {0} C° \n", Math.Round(celsius));
                }
                else if (celsius > 77)
                {
                    Console.WriteLine("Det är för varmt, öppna dörren {0} C° \n", Math.Round(celsius));
                }
                // Uppfylls detta villkor kastas man ut ur loopen.
                else if (celsius > 73 && celsius < 77 && celsius != 75)
                {
                    Console.WriteLine("nu är det OK att basta {0} C° ", Math.Round(celsius));
                    break;
                }
                // Uppfylls detta villkor kastas man ut ur loopen.
                else if (celsius == 75)
                {
                    Console.WriteLine("Nu är det perfekt temeratur att basta \n Välkommen in i bastun ", Math.Round(celsius));
                    break;
                }
                /* Denna har jag med bara för att visa att jag har en fungerade 
                 * slumptalsmetod. Jag kom inte på hur jag skulle göra för att 
                 * använda den till att kolla av villkoren för bastun*/
                Console.WriteLine("SlumpTal {0}", (slumpTal)); 
                
            }
            Console.ReadKey(); // slut
        }
    }
}

