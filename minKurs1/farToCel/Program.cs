using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farToCel
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] minaTal = new int[5];

            minaTal[0] = 15;
            minaTal[1] = 26;
            minaTal[2] = 38;
            minaTal[3] = 42;
            minaTal[4] = 55;

            for (int tal = minaTal.Length -1; tal >=0 ; tal-- )
            {
                
                Console.WriteLine("Indexposition {0} har värdet {1} ", tal, minaTal[tal]);
                
            }
            Console.ReadKey();

            /*
            float originalFarenheit;
            float centigrade;
            float returnFarenheit;

            Console.Write("Enter Temperature (Farenheit): ");      //take temp to be converted
            originalFarenheit = float.Parse(Console.ReadLine());   //hold as float var
            centigrade = ((originalFarenheit - 32) / 9) * 5;       //Convert to centrigrade
            returnFarenheit = ((centigrade / 5) * 9) + 32;         //test conversion by reversing

            Console.WriteLine("Centigrade = :" + centigrade);              //Display result
            Console.WriteLine("Return Farenheit = :" + returnFarenheit);   //Test result

            Console.ReadKey();
            */
        }
    }
}
