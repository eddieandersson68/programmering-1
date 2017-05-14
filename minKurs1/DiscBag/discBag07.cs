using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinDiscBag
{
    class MinDiscBag
    {
        Disc[] discBag = new Disc[5];
        //public static void ResetArray(int[] x) // Metod för att se till att vektorerna är "nollade"
        //{
        //    for (int i = 0; i > x.Length; i++)
        //        x[i] = 0;
        //}
        public int antal_discar = 0; //Håller reda på antal discar
        public void Run()
        {
            int menu = 0; // variabel som håller read på vilket menyval som gjorts
            do
            {
                Console.ResetColor();
                //Console.ForegroundColor = ConsoleColor.Yellow;
                //Console.WriteLine("\t");
                Console.WriteLine("******************************************************************");
                Console.WriteLine("*                                                                *");
                Console.WriteLine("* Välkommen till din alldeles egna Discbags simulator            *");
                Console.WriteLine("*                                                                *");
                Console.WriteLine("* var god välj ett alternativ                                    *");
                Console.WriteLine("*                                                                *");
                Console.WriteLine("* 1. Lägg till en disc                                           *");
                Console.WriteLine("* 2. Ta bort en disc                                             *");
                Console.WriteLine("* 3. Byt ut en disc                                              *");
                Console.WriteLine("* 4. Räkna ut det sammanlagda värdet av din discbag              *");
                Console.WriteLine("* 5. Skriv ut innehållet i din discbag                           *");
                Console.WriteLine("* 6. Töm din discbag och börja om                                *");
                Console.WriteLine("* 0. Avsluta programmet                                          *");
                Console.WriteLine("*                                                                *");
                Console.WriteLine("*                                                                *");
                Console.WriteLine("******************************************************************");
                Console.WriteLine(" ");
                int.TryParse(Console.ReadLine(), out menu);
                //if (menu > 0 && menu < 5)
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
                        CalcDiscs();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Den totala kostnade av dina discar är {0} kr", CalcDiscs());
                        break;
                    case 5:
                        PrintDiscbag();
                        break;
                    case 6:
                        EmptyDiscBag();
                        break;
                    case 0:
                        Console.WriteLine("Programmet avslutas");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Felaktig inmatning ");
                        break;
                }
            } while (menu != 0);
            DiscBagFull();
        }
        public void AddDisc()
        {

            //if (antal_discar == discBag.Length)
            //{
            //    Console.Clear();
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("\nDin diskbag är full");
            //    Console.ResetColor();
            //    Console.WriteLine("\nVar god välj ett annat alternativ");
            //}
            if (antal_discar < discBag.Length - 1)
            {
                int temp = 0; // variabel som håller read på vilket menyval som gjorts
                do
                {
                    DiscBagFull();
                    Console.ResetColor();
                    Console.WriteLine("\nVar god välj disk typ\n");
                    Console.WriteLine("1: Driver");
                    Console.WriteLine("2: Midrange");
                    Console.WriteLine("3: Putter");
                    Console.WriteLine("0: Backa tillbka till föregående meny");
                    //Console.Clear();
                    int.TryParse(Console.ReadLine(), out temp); // fångar upp om man slagit in en bokstav eller en felaktigt siffra.
                    switch (temp)
                    {
                        case 1:
                            AddDriver();
                            break;
                        case 2:
                            AddMidRange();
                            Console.WriteLine();
                            break;
                        case 3:
                            AddPutter();
                            Console.WriteLine();
                            break;
                        case 0:
                            Console.WriteLine("0: Du backade tillbka till föregående meny");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Felaktig inmatning ");
                            break;
                    }

                } while (temp != 0);
            }
            //else
            //{
            //    Console.WriteLine("\nDin diskbag är full");
            //    Console.WriteLine("0: Backa tillbka till föregående meny");
            //}
        }

        public void AddDriver()
        {
            int temp = 0; // variabel som håller read på vilket menyval som gjorts
            do
            {
                DiscBagFull();
                Console.ResetColor();
                Console.WriteLine("\nVar god välj driver");
                Console.WriteLine("1: Freedom");
                Console.WriteLine("2: Saint Pro");
                Console.WriteLine("3: Star Destroyer");
                Console.WriteLine("0: Backa tillbka till föregående meny");
                int.TryParse(Console.ReadLine(), out temp); // fångar upp om man slagit in en bokstav eller en felaktigt siffra.
                switch (temp)
                {
                    case 1:
                        discBag[antal_discar] = new DiscDriver("Dynamic Discs", "Driver", "Freedom", 189);
                        antal_discar++;
                        break;
                    case 2:
                        discBag[antal_discar] = new DiscDriver("Lattitude 64", "Driver", "Saint Pro", 169);
                        antal_discar++;
                        break;
                    case 3:
                        discBag[antal_discar] = new DiscDriver("Innova", "Driver", "Star Destroyer", 159);
                        antal_discar++;
                        break;
                    case 0:
                        Console.WriteLine("0: Du backade tillbka till föregående meny");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Felaktig inmatning ");
                        break;
                }
            }

            while (temp != 0);
        }
        public void AddMidRange()
        {

            int temp = 0; // variabel som håller read på vilket menyval som gjorts
            do
            {
                DiscBagFull();
                Console.ResetColor();
                Console.WriteLine("\nVar god välj midrange");
                Console.WriteLine("1: Truth");
                Console.WriteLine("2: Core");
                Console.WriteLine("3: Cobra");
                Console.WriteLine("0: Backa tillbka till föregående meny");
                int.TryParse(Console.ReadLine(), out temp); // fångar upp om man slagit in en bokstav eller en felaktigt siffra.
                switch (temp)
                {
                    case 1:
                        discBag[antal_discar] = new MidRange("Dynamic Discs", "Midrange", "Truth", 170);
                        antal_discar++;
                        break;
                    case 2:
                        discBag[antal_discar] = new MidRange("Lattitude 64", "Midrange", "Core", 145);
                        antal_discar++;
                        break;
                    case 3:
                        discBag[antal_discar] = new MidRange("Innova", "Midrange", "Cobra", 137);
                        antal_discar++;
                        break;
                    case 0:
                        Console.WriteLine("0: Du backade tillbka till föregående meny");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Felaktig inmatning ");
                        break;
                }
            } while (temp != 0);
        }
        public void AddPutter()
        {
            int temp = 0; // variabel som håller read på vilket menyval som gjorts
            do
            {
                DiscBagFull();
                Console.ResetColor();
                Console.WriteLine("\nVar god välj putter");
                Console.WriteLine("1: Judge");
                Console.WriteLine("2: Mercy");
                Console.WriteLine("3: Aviar");
                Console.WriteLine("0: Backa tillbka till föregående meny");
                int.TryParse(Console.ReadLine(), out temp); // fångar upp om man slagit in en bokstav eller en felaktigt siffra.
                switch (temp)
                {
                    case 1:
                        discBag[antal_discar] = new Putter("Dynamic Discs", "Putter", "Judge", 173);
                        antal_discar++;
                        break;
                    case 2:
                        discBag[antal_discar] = new Putter("Lattitude 64", "Putter", "Mercy", 165);
                        antal_discar++;
                        break;
                    case 3:
                        discBag[antal_discar] = new Putter("Innova", "Putter", "Aviar", 147);
                        antal_discar++;
                        break;
                    case 0:
                        Console.WriteLine("0: Du backade tillbka till föregående meny");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Felaktig inmatning ");
                        break;
                }
            } while (temp != 0);
        }

       
        public void SubDisc()

        /* För att ta bort ett element från en array kan man även förskjuta hela arrayn ett 
         * steg så den man vill ska bort skrivs över av den som är på platsen + 1 och alla andra 
         * flyttas ett steg till vänster efter denna, sen sätta sista objektet som finns i array till null 
         * (det kommer att finnas två av denna annars). Vilket fungerar utmärkt om man hela tiden fyller på längst bak, 
         * bara man inte glömmer att minska count med 1 för varje man tar bort.
         */
        {

            //for (int i = 0; i < discBag.Length; i++)
            //{
            //    discBag[i] = antal_discar;
            //}
            //int indexToRemove = 0;
            //discBag = discBag.Where((source, index) => index != indexToRemove).ToArray();
        }
        public void SwapDisc()
        {
            //var temp= 0;
            //Item Temp = discBag.[2];
            //discBag[2] = discBag[3];
            //discBag[3] = Temp;
            Console.WriteLine("Du bytte en disc");
        }
        //// Print Metod ////
        public void PrintDiscbag()
        {
            ////int count = 0;
            //foreach (var antal_discar in discBag)
            //{
            //    if (antal_discar != null)
            //        Console.WriteLine("{0} ", antal_discar); // skriver ut till consollen vad för discar man lagt till
            //    else
            //    {
            //        Console.WriteLine("\nTom plats");
            //    }
            //}
            //Console.WriteLine("\nDu har {0} discs i din discbag.", antal_discar); // antal discar i din bag
            //Console.WriteLine("Du har {0} platser i din discbag.", discBag.Length); // antal platser i din bag
            //////////////////////////////////////////////////////////////////////////////////////////////////
            int count = 0;
            for (int i = 0; i < discBag.Length; i++)
            {
                if (discBag[i] != null)
                {
                    Console.WriteLine("Index : {0} {1}", i, discBag[i]); // writes to the console what been added
                    count++;
                }
                else
                {
                    Console.WriteLine("\nEmpty slot");
                }
            }
            Console.WriteLine("\nYou have {0} discs in your  discbag.", count);
            Console.WriteLine("You have {0} slots in your discbag.", discBag.Length);
        }
        public double CalcDiscs()
        {
            double price = 0;
            foreach (var antal_discar in discBag)
            {
                if (discBag != null && antal_discar != null)
                    price += antal_discar.get_price();
            }
            //antal_discar--;
            return price;
        }
        public void EmptyDiscBag()
        {
            for (int i = 0; i < discBag.Length; i++)
            {
                discBag[i] = null;
            }
            antal_discar = 0;
        }
        public void DiscBagFull() // Metod för att meddela att discbagen är full.
        {
                if (antal_discar == 5)
            { 
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDin diskbag är full");
                Console.ResetColor();
                Console.WriteLine("\nVar god välj ett annat alternativ");
                //return (antal_discar == discBag.Length - 1);
                Run();
            }
        }
        // Abstract class för discar.
        public abstract class Disc
        {
            // privata class egenskaper
            protected string make;
            protected string type;
            protected string name;
            public double price;
            protected Disc(string Make, string Type, string Name, double Price)
            {
                Console.WriteLine("Basklass");
                make = Make;
                type = Type;
                name = Name;
                price = Price;
            }
            // Publika lokala egenskaper
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
            public double Price
            {
                get { return price; }
                set { price = value; }
            }
            public override string ToString() // Publik Metod för att skriva ut egenskaperna på ett objekt i textform.
            {
                string text = null; // En variablen kallad text som innehåller de olika egenskapera ett objekt har.
                text += "\nTillverkare " + Make;
                text += "\nTyp " + Type;
                text += "\nNamn " + Name;
                text += "\nPris kr " + price;
                return text;
            }
            public double get_price()
            {
                return price;
            }
            ///////////////// Konstruktor för en ny disc av typen driver ////////////
        }
        class DiscDriver : Disc
        {
            public DiscDriver(string Make, string Type, string Name, double Price) : base(Make, Type, Name, Price)
            {
                Console.WriteLine("Ärvande klass");
            }
        }
        class MidRange : Disc
        {
            public MidRange(string Make, string Type, string Name, double Price) : base(Make, Type, Name, Price)
            {
                Console.WriteLine("Ärvande klass");
            }
        }
        class Putter : Disc
        {
            public Putter(string Make, string Type, string Name, double Price) : base(Make, Type, Name, Price)
            {
                Console.WriteLine("Ärvande klass");
            }
        } 
    }
    class Program
    {
        public static void Main(string[] args)
        {
            //Skapar ett objekt av klassen DiscBag som heter minDiscbag
            var mindiscbag = new MinDiscBag();
            mindiscbag.Run();
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}