using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace amerikanen_I_Bastun
{

    class Program
    {
        static bool ISsaunaHotEnough(float fahrenheit)
        {
            if (fahrenheit < 164 && fahrenheit > 167)
            {
                return false;
            }
            return true;
        }
        // Metod fÃ¶r att omvandla Farhrenheit till Celcius (int)
        public static int FahrToCelsI(int fahr)
        {

            int cel = ((fahr - 32) / 9) * 5;
            return cel;

        }
        // Metod för att omvandla Farhrenheit till Celcius (float)
        public static float FahrToCelsF(int fahr)
        {
            return ((fahr - 32.0f) / 9.0f) * 5.0f;
        }


        public static float GetTemparatureFromInput()
        {
            try
            {
                return FahrToCelsF(int.Parse(Console.ReadLine()));
            }
            catch (Exception ex)
            {
                Console.WriteLine("FEL vid inmatning" + ex.Message);
                throw;
            }
        }

        public static void Main(string[] args)
        {


            while (true)
            {
                var celsius = 0.0f;
                Console.WriteLine("Skriv in önskad temperatur ");
                try
                {
                    celsius = GetTemparatureFromInput();
                }
                catch (Exception ex)
                {
                    continue;
                }

                if (celsius < 73)
                {
                    Console.WriteLine("Det är inte varmt nog, höj temperaturen. Nu är det {0} C", 73 - Math.Round(celsius));
                }
                else if (celsius > 77)
                {
                    Console.WriteLine("Det är för varmt, öppna dörren för att minska med {0} C", Math.Round(celsius) - 77);
                }

                else if (celsius > 73 && celsius < 77)
                {
                    Console.WriteLine("nu är det OK att basta {0} C", Math.Round(celsius));
                    break;
                }
                else
                {
                    Console.WriteLine("Nu är det perfekt temeratur ", Math.Round(celsius));
                }

            }

            Console.ReadKey();
        }
    }
}