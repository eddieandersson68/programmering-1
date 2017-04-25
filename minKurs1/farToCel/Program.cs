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
            // while loop som räknar från 0 till 10. Lägg märke till att värdet på i måste sättas till -1.
            int i = -1;
            Console.WriteLine("\n while loop 0-10");
            while (i < 10)
            {
                i++;
                Console.WriteLine(i);
            }
            // while loop som räknar från 10 till 0. Lägg märke till att värdet på j måste sättas till 11.
            int j = 11;
            Console.WriteLine("\n while loop 10-0");
            while (j >0)
            {
                j--;
                Console.WriteLine(j);
            }

            ///////////////////////////////////////////
            // Do while loop från 0 till 10. Lägg märke till att värdet på y måste sättas till -1.
            Console.WriteLine("\n DO while loop 0-10");
            int y = -1;
            do
            {
                y++;
                Console.WriteLine(y);
            }
            while (y < 10);

            // Do while loop från 10 till 0. Lägg märke till att värdet på y måste sättas till 11.
            Console.WriteLine("\n DO while loop 10-0");
            int z = 11;
            do
            {
                z--;
                Console.WriteLine(z);
            }
            while (z > 0);
            ///////////////////////////////////////////
            // For loop från 0 till 10. Lägg märke till att värdet x inte behöver sättas till -1, här måste istället villkoret vara till 11.
            Console.WriteLine("\n for loop 0-10");
            for (int x = 0; x < 11; x++)
                Console.WriteLine(x);
            // For loop från 10 till 0. Lägg märke till att värdet a inte behöver sättas till 11 i for loopen, här måste istället villkoret vara till >=0
            Console.WriteLine("\n for loop 10-0");
            for (int a = 10; a >=0; a--)
                Console.WriteLine(a);


            /////////////////////////////////////////////
            // for loop
            string[] names = new string[3];
            names[0] = "Eddie";
            names[1] = "Susanne";
            names[2] = "Alex";

            for (int s = 0; s < names.Length; s++) 
            {
                Console.WriteLine(names[s]);
            }
            

            // foreach loop
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
            ///////////////////////////////////////////
            /*
                        int[] minaTal = new int[5];

                        minaTal[0] = 15;
                        minaTal[1] = 26;
                        minaTal[2] = 38;
                        minaTal[3] = 42;
                        minaTal[4] = 55;

                        int[] minaTal2 = new int[5];

                        minaTal2[0] = 15;
                        minaTal2[1] = 16;
                        minaTal2[2] = 17;
                        minaTal2[3] = 18;
                        minaTal2[4] = 19;

                        for (int tal = minaTal.Length - 1; tal >= 0; tal--)
                        {

                            Console.WriteLine("Indexposition {0} har värdet {1} \n", tal, minaTal[tal]);

                        }
                        ///////////////////////////////////////////////////////////////////////////////////

                        for (int tal = minaTal2.Length - 1; tal >= 0; tal--)
                        {

                            Console.WriteLine("Indexposition {0} har värdet {1} \n", tal, minaTal2[tal]);

                        }
                        Console.ReadKey();
                        */
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
