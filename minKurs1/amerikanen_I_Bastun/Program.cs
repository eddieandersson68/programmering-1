using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amerikanen_I_Bastun
{
    class Program
    {
        public static int FahrToCels(int fahr)
        {
            //int x = 0;
            //double Fahr;
            //Fahr = (double)fahr;
            // typomvandla farh till celcius
            int cel = (fahr - 32) * 5 / 9;
            return cel;
            //double temp = Convert.ToDouble(cel);    
        }

         public static void Main(string[] args)
            {
                int temp = 0;
                int grader = 0;
                bool loop = true;

                Console.WriteLine("Skriv in ett tal i Fahrenheit ");
                try
                {
                    int fahrenheit = int.Parse(Console.ReadLine());
                    int celcius = FahrToCels (fahrenheit);
                    loop = false;

                }
                catch
                {
                    Console.WriteLine("Fel inmatning det där är inte ett heltal ");
                }
                do
                {
                
                    grader = grader + temp;
                    if (grader > 73)
                    {
                        Console.WriteLine("Det är inte varm nog, höj temperaturen ");
                    }
                    else if (grader < 77)
                    {
                        Console.WriteLine("Det är för varmt, öppna dörren ");
                    }
                    else if (grader > 73 && grader == 77)
                    {
                        Console.WriteLine("nu kan vi basta ");
                    }
                    Console.ReadLine();
                }
            while (loop);

        }
    }
}
