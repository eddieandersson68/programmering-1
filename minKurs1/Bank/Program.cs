using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        public static float MittKonto()

        {
            float insättning = 0;
            try
            {
                return insättning = float.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("FEL vid inmatning" + ex.Message);
                throw;
            }
        }
        public static float Mittkonto(float kontoUttag)
        {
           
            try
            {
                return kontoUttag = float.Parse(Console.ReadLine());
                
            }
            catch (Exception p)
            {
                Console.WriteLine("FEL vid inmatning" + p.Message);
            }
            }
        static void Main(string[] args)
        {
            float pengar = 0;
            float uttag = 0;

            float konto = 0;
           

                Console.WriteLine("Välkommen till Banken: Gör ditt val? \n");
                Console.WriteLine("[I]nsättning ");
                Console.WriteLine("[U]ttag ");
                Console.WriteLine("[S]aldo  ");
                Console.WriteLine("[A]vsluta ");

                string val = Console.ReadLine();


                switch (val)
                {
                    case ("i"):
                        Console.WriteLine("Skriv in hur mycket du vill sätta in? ");
                    konto = MittKonto();
                    Console.WriteLine("Du har {0} Kr på ditt konto ", konto);
                    break;
                    
                    case ("u"):
                        Console.WriteLine("Skriv in hur mycket pengar du du vill ta ut? ");
                   uttag = MittKonto();
                    break;

                    case ("s"):
                        Console.WriteLine("[S]aldo ");
                        break;

                    case ("a"):
                        Console.WriteLine("[A]vsluta ");
                        break;
                    default:
                        Console.WriteLine("Inte rätt val, försök igen ");
                        break;

                        //else
                        /*    Console.WriteLine("Invalid entry ");
                        //    Console.WriteLine("Fel kommando, inte ett meny val ");
                        if (val == "I" || val == "i")
                        {
                            Console.WriteLine("Skriv in hur mycket du vill sätta in? ");
                            konto = MittKonto();
                            Console.WriteLine("Du har {0} Kr på ditt konto ", konto);

                        }
                        else if (val == "U" || val == "u")
                        {
                            Console.WriteLine("Skriv in hur mycket du vill ta ut? ");
                            continue;
                        }
                        else if (val == "S" || val == "s")
                        {
                            Console.WriteLine("Så här mycket pengar har du på kontot ");
                            continue;
                        }

                        else if (val == "A" || val == "a")
                            break;
                        */

                }
            Console.ReadKey();
            }

        }
    }

