using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        public static float MittKontoIn()
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
        public static float MittKontoUt()
        {
            float uttag = 0;
            try
            {
                return uttag = float.Parse(Console.ReadLine());
            }
            catch (Exception p)
            {
                Console.WriteLine("FEL vid inmatning" + p.Message);
                throw;
            }
        }
        static void Main(string[] args)
        {
            float pengarIn = 0;
            float pengarUt = 0;

            float konto = 0;
            while (true)
            {
                


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
                        pengarIn += MittKontoIn();
                        konto = pengarIn;
                        Console.WriteLine("Du har {0} Kr på ditt konto ", konto);
                        break;
                    case ("u"):
                        Console.WriteLine("Skriv in hur mycket pengar du du vill ta ut? ");
                        pengarUt = MittKontoUt();
                        konto = konto - pengarUt;
                        Console.WriteLine("Du har {0} Kr på ditt konto ", konto);
                        break;
                    case ("s"):
                        Console.WriteLine("[S]aldo ");
                        Console.WriteLine("\n"+konto);
                        break;
                    case ("a"):
                        Console.WriteLine("[A]vsluta ");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Inte rätt val, försök igen ");
                        break;
                }

            }


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
            
        }

    }


