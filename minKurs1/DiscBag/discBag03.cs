﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscBag
{
    class MinDiscBag
    {

        //const int ARRAY_SIZE = 5; // Ett konstant värde Så att jag bara har ett ställe att ändra på om jag behöver öa lr minska min vektor.
        //Disc[]  discBag = new Disc[ARRAY_SIZE]; // Skapar en ny vektor med antal platser som defineras i variablen ARRAY_SIZE ovan.

        private int antal_discar = 0; //Håller reda på antalet discar.
                                      //int sum = 0; // Summa för det totala värdet av alla discar.
                                      //int[] midrange = new int[5]; // == antalet discar som jag lagt till av denna typ
                                      //int[] putter = new int[5]; // == antalet discar som jag lagt till av denna typ
                                      //(Betyg A): En konstruktor kan ni använda för Sodacrate men det är inget krav.
                                      //(Betyg A): Däremot ska ni använda en konstruktor för klassen "Soda"

        private Disc[] discar;
        public MinDiscBag()
        {
            discar = new Disc[5];
        }

        public void Run()
        {
            int menu = 0;
            do
            //while (menu)
            {
                Console.WriteLine("\t");
                Console.WriteLine("\n" + "Välkommen till din alldeles egna Discbags simulator ");
                Console.WriteLine("var god välj ett alternativ ");
                Console.WriteLine("1. Lägg till en disc");
                Console.WriteLine("2. Ta bort en disc");
                Console.WriteLine("3. Byt ut en disc");
                Console.WriteLine("4. Räkna ut det sammanlagda värdet av din discbag");
                Console.WriteLine("5. Skriv ut innehållet i din discbag");
                Console.WriteLine("0. Avsluta programmet");
                Console.WriteLine(" ");
                int.TryParse(Console.ReadLine(), out menu);
                switch (menu)
                {
                    case 1:
                        AddDisc();
                        break;
                    case 2:
                        SubDisc();
                        break;
                    case 3:
                        SwapDisc();
                        break;
                    case 4:
                        //CalcDiscs();
                        break;
                    case 5:
                        PrintDiscbag();
                        break;
                    case 0:
                        Console.WriteLine("Programmet avslutas");

                        break;
                    default:
                        Console.WriteLine("Felaktig inmatning ");
                        //menu = false;
                        break;
                }
            } while (menu != 0);
        }
        public void AddDisc()
        {
            int temp = 0;
            do
            {
                Console.WriteLine("Var god välj disk typ");
                Console.WriteLine("1: Driver");
                Console.WriteLine("2: Midrange");
                Console.WriteLine("3: Putter");
                Console.WriteLine("0: Backa tillbka till föregående meny");
                //Console.Clear();
                int.TryParse(Console.ReadLine(), out temp);
                switch (temp)
                {
                    case 1:
                        AddDriver();
                        break;
                    case 2:
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine();
                        break;
                    case 0:
                        Console.WriteLine("4: Du backade tillbka till föregående meny");
                        break;
                    default:
                        Console.WriteLine("Felaktig inmatning ");
                        break;
                }
            } while (temp != 0);
        }
        public void AddDriver()
        {
            if (antal_discar <= 5)
            {
                discar[0] = new Disc("Lattitude 64", "Driver", "Freedom", 169);
                //discBag[antal_discar] = new Driver();
                //antal_discar++;
            }
            else
            {
                Console.WriteLine("Bagen är full");
            }
        }
        public void SubDisc()
        {
            //Console.WriteLine("vilken disk vill du ta bort? ");
            //discBag.Add= string name = (Console.ReadLine());  
            //if (discBag[0]= name)         
            ////{
            //int indexToRemove = 0;
            //int discIndex = Array.IndexOf(discBag, indexToRemove);
            //discBag = discBag.Where((val, idx) => idx != discIndex).ToArray();
            ////discBag = discBag.Where((source, index) => index != indexToRemove).ToArray();
            ////}
            //discBag[];
            //antal_discar--;
        }
        public void SwapDisc()
        {
            Console.WriteLine("Du bytte en disc");
        }

        //// Print Metod ////

        public void PrintDiscbag()
        {
            foreach (var temp in discar)
            {
               Console.WriteLine(temp);
            }

            ////int count = 0;
            //foreach (var temp in discBag) //För varje disc plats i bagen kollar vi Om det faktiskt är en disc i bagen och inte en tom plats.
            //{
            //    if (temp != null)
            //        Console.WriteLine("{0}", temp, discBag);
            //    else
            //        Console.WriteLine("\nTom plats");
            //}
            //{
            //    if (antal_discar != 0) count += 1; /
            //}
            //foreach (int antal_discar in discBag)
            //{
            //discBag.ToList().ForEach(Console.WriteLine);

            //Console.WriteLine(antal_discar.ToString());
            //Console.WriteLine(discBag[1].ToString());
            //Console.WriteLine("\nDu har {0} discar i din discbag.", antal_discar);



            //foreach (string temp in discBag)
            //Console.WriteLine(temp);
            //kod här
            //Missa inte hjälpkoden som finns i projektbeskrivningen
            //Där beskrivs hur man löser det med tomma positioner i vektorn
        }
        //public int CalcDiscs()
        //{

        ////    //int sum = 0;
        ////    //for (int i = 0; i < discBag.Length; i++)
        ////    //{
        ////    //    sum = discBag[antal_discar];
        ////    //    Console.WriteLine(sum);
        ////    //}
        ////    //return sum;


        ////    //Console.WriteLine("Räkna ut totalsumman av alla diskar "+ disc.price + disc. );
        ////    //kod här
        ////    //Tänk på att inte räkna med tomma positioner i vektorn
        //}
        public void findDisc()
        {
            //Betyg C
            //Beskrivs i läroboken på sidan 147 och framåt (kodexempel på sidan 149)
            //Man ska kunna söka efter ett namn
            //Man kan använda string-metoderna ToLower() eller ToUpper() 
        }
        public void sortDiscs()
        {
            //Betyg A-C
            //Beskrivs i läroboken på sidan 147 och framåt (kodexempel på sidan 159)
            //Man ska kunna sortera vektorn med flaskor och med bubble sort
            //Det är mycket svårt att sortera efter bokstavsordning - är inte flaskorna egna objekt utan bara strängar...
            //... går det bra att sortera efter längden på namnet istället. 
        }


   

    }
    public class Disc
    {
        private string make;
        private string type;
        private string name;
        private int price;
        public Disc(string Make, string Type, string Name, int Price)
        {
            Make = make;
            Type = type;
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return string.Format("Discen är av tillverkaren {0}) och heter {3} samt kostar {4}",make, name, price );
         }

        //private disc[] drivers;
        //protected string make;
        //protected string type;
        //protected string name;
        //protected int price;

        //public string Make
        //{
        //    get { return make; }
        //    set { make = value; }
        //}
        //public string Type
        //{
        //    get { return type; }
        //    set { type = value; }
        //}
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        //public int Price
        //{
        //    get { return price; }
        //    set { price = value; }
        //}

        ////public Disc()
        //{
        //    Make = "Lattitude";
        //    Type = "Driver";
        //    Name = "Freedom";
        //    Price = 169;
        //}
    }
    //public override string ToString()
    //{
    //    string text = null;
    //    text += "\nTillverkare " + Make;
    //    text += "\nNamn " + Name;
    //    text += "\nTyp " + Type;
    //    text += "\nPris kr " + price;
    //    return text;
    //}

    ///////////////// Konstruktor för en ny disc av typen driver ////////////
    //public Disc(string Make, string Type, string Name, int Price)
    //{

    //}
    class Program
    {
        public static void Main(string[] args)
        {
            //Skapar ett objekt av klassen DiscBag som heter minDiscbag
            var mindiscbag = new MinDiscBag();
            mindiscbag.Run();
            mindiscbag.AddDriver();
            mindiscbag.PrintDiscbag();
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
//make = Make;
//    Type = type;
//    name = Name;
//    price = Price;
//drivers = new Disc[5];

//     public static void AddDriver()
//{

//    //    drivers[0] = new Disc("Lattitude", "Driver", "Freedom", 169);
//    //    drivers[1] = new Disc("Lattitude", "Driver", "Saint Pro", 189);
//    //}
//}
//public class Driver : Disc
//{

//    //public Driver() : base("Lattitude 64", "Driver", "Freedom", 169);

//}
//public Driver() : base("Lattitude 64", "Driver", "Freedom", 169)
//{





// public properties skrivs med Pascal case eller _name

//int[] driver = new int[5]; // En vektor för att hålla 5 olika typer av drivers 
//int[] midrange = new int[5]; // == antalet discar som jag lagt till av denna typ
//int[] putter = new int[5]; // == antalet discar som jag lagt till av denna typ

/* class DiscMidrange:Disc
 {
     private int[] midrange;
     private string make;
     private string type;
     private string name;
     private int price;

     public DiscMidrange(string Make, string Type, string Name, int Price)
     {
         make = Make;
         Type = type;
         name = Name;
         price = Price;
         midrange = new int[5];
     }
     public string Make
     {
         get { return make; }
         set { make = value; }
     }
     public string Type
     {
         get { return type; }
         set { type = value; }
     }
     public string Name
     {
         get { return name; }
         set { name = value; }
     }
     public int Price
     {
         get { return price; }
         set { price = value; }
     }
 }*/
//Här ska menyn ligga för att göra saker
//Jag rekommenderar switch och case här med en loop
//I del 1 av filmerna för slutprojektet kodar jag en switch case
/*Metod för att lägga till en disc
Om ni har information om både pris, läsktyp och namn
kan det vara läge att presentera en meny här där man kan
välja på förutbestämda läskflaskor. Då kan man också rätt enkelt
göra ett val för att fylla läskbacken med slumpade flaskor
*/











/*public struct Soda 
{
   Siktar ni mot specifikt betyget C och inte vill göra en egen klass av Soda så kan det fungera bra med en struct istället som ni definierar här
   Den kan då tre olika värden för namn, pris, och dryckestyp. Då blir hela projektet roligare - såsom sortering och uträkning av pris
 * Denna struct del bortser ni ifrån helt om ni inte vill jobba med detta och då alltså specifikt för betyget C 
}*/
