using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryTest
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

        static void Main(string[] args)
        {

            /////////////////////////////////////////////////////////////////
            // Bank Inte klart
            while (true)
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

            }
            Console.ReadLine();
        }

    }
}




/* int nr = int.Parse(Console.ReadLine());
switch (nr)
{
 case 1:
     Console.WriteLine("Skriv in hur mycket du vill sätta in? ");
     break;

 case 2:
     Console.WriteLine("Skriv in hur mycket du vill ta ut? ");
     break;

 case 3:
     Console.WriteLine("[S]aldo {0} ");
     break;

 case 4:
     Console.WriteLine("[A]vsluta ");
     break;
     */
//else
//    Console.WriteLine("Invalid entry ");
//    Console.WriteLine("Fel kommando, inte ett meny val ");






////////////////////////////////////

/*  public static void Insättning(int money)
  {

  }
  public static void Uttag()
  {

  }
  public static void Saldo()
  {

  }
  public static void Avsluta()
  {

  }
*/






//}
//}
//int a = 1;
//int b = 2;
//float c = a / b;

//float svar = Convert.float(c);
//Console.WriteLine(svar);

//////////
// Saga //
//////////
//            string namn1, namn2;

//            Console.WriteLine("Skriv in två namn \n");
//            Console.WriteLine("Skriv namn nr1: \n");
//            namn1 = Console.ReadLine();
//            Console.WriteLine("Skriv namn nr2 ");
//            namn2 = Console.ReadLine();

//            Console.WriteLine("\t\t\t\t Sagan om {0} och {1}\n\n ", namn1, namn2);

//            Console.WriteLine(@"    Det var en gång en stålig man som hette {0} han kände sig väldigt ensam och olycklig i sitt liv, 
//    men så en dag var det någon som sa åt honom att testa en app som heter Tinder?
//    Via denna app så hittade {0} en kvinna som hette {1}, {0}  
//    tyckte hon såg trevlig ut, så han tänkte att jag Swipar höger!  
//    Så hoppades han att även {1} skulle Swipa honom till höger? 
//    Sagt och gjort så gjorde {0}. Det skulle visa sig att det gjorde även {1}.  
//    Så gick det till då {0} och {1} fick varandra" + " \r\n\n\t\t\t\t\t " + " SLUT", namn1, namn2);

//            Console.ReadKey();
//        }
//    }
//}


/////////////////////////////////////////////////////////////////
// Program för att avrunda ett decimaltal till närmsate heltal //
////////////////////////////////////////////////////////////////
//Console.WriteLine("Skriv in ett decimaltal, så ska jag avrunda det ");
//string decTal = Console.ReadLine();


//double konverteratTal = Convert.ToDouble(decTal);
//double svar = Math.Round((Double)konverteratTal, 0);

//Console.WriteLine("Här är ditt {0} ", decTal + " avrundat till närmsta heltal: \n" + svar);
//Console.ReadKey();

////////////////////////////////////////////////////////////////////////
// Mata in tre tal och lägg samman och visa medelvärdet av dessa tal //
//////////////////////////////////////////////////////////////////////
//int tal1 = 0;
//int tal2 = 0;
//int tal3 = 0;
//int  medel = 0;
//int summa = 0;

//Console.WriteLine("Skriv in tre tal \n");
//Console.Write("Skriv in tal nr1 ");
//tal1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Skriv in tal nr2 ");
//tal2 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Skriv in tal nr3 ");
//tal3 = Convert.ToInt32(Console.ReadLine());


//summa = (tal1 + tal2 + tal3);
//medel = (summa / 3);

//Console.WriteLine("Summan av dina tal är {0} ", summa);


//Console.WriteLine("Medelvärdet av dina tal är {0} ", medel);
//Console.ReadLine();



////////////////////////////////////////////
// Mata in två tal och lägg samman dessa //
//////////////////////////////////////////
//int tal1 = 0;
//int tal2 = 0;
//int summa = 0;

//Console.WriteLine("Skriv in två tal \n");
//Console.Write("Skriv in tal nr1 ");
//tal1 = Convert.ToInt32(Console.ReadLine()); 
//Console.Write("Skriv in tal nr2 ");
//tal2 = Convert.ToInt32(Console.ReadLine());


//summa = (tal1 + tal2);


//Console.WriteLine("Summan av dina tal är {0} ", summa);
//Console.ReadLine();





//////////////////////////////////////////////////////////////////
// Skapar en metod som heter PrinMe som skriver ut en hälsning. //
/////////////////////////////////////////////////////////////////
// Är metoden inte statisk måste vi göra en instanskopia av klassen. 
// Det gör man med nyckelordet new. En instans av en klass kan bara göras på icke statiska klasser. 
// Nedan följer ett exempel på användning av en icke statisk metod. 
// Det skapas en instans av klassen Program som döps till program. Instansen anropar sen metoden.



//    Program program = new Program(); // En ny instans av klassen Program skapas.
//    program.PrintMe("Eddie");
//}
//    public void PrintMe(string name) // Icke statiskt metod
//{
//    Console.WriteLine("hej {0}", name);
//    Console.ReadLine();
//}

////////////////
/// Try test //
////////////////
//try
//{
//    Console.WriteLine("Skriv in ett helytal. ");
//    int tal = int.Parse(Console.ReadLine());
//    Console.WriteLine("Du skrev {0}",tal);
//}
//catch(Exception ex)
//{
//    Console.WriteLine("Fel du skrev inte in ett heltal! ");
//    Console.WriteLine(ex.Message);

//}




