using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinDiscBag
{
    class MinDiscBag
    {
        Disc[] discBag = new Disc[5]; /* Storleken på vekotorn som anger hur många platser du har i bagen., 
        Satt till 5 nu av testskäl, men den kan enkelt ändras till den storlek man vill ha på sin bag.*/

        public int antal_discar = 0; //Variabel som håller reda på antal discar i bagen.
        public void Run()
        {
            int menu = 0; // Variabel som håller reada på vilket menyval som gjorts
            do
            {
                Console.ResetColor(); // återställer text färgen till vit om den ändrats.
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
                switch (menu)
                {
                    case 1:
                        AddDisc(); // Kallar på metoden för att lägga till en disc i bagen.
                        break;
                    case 2:
                        SubDisc(); // Kod saknas :( 
                        break;
                    case 3:
                        SwapDisc();// Kod saknas :( 
                        break;
                    case 4:
                        CalcDiscs(); // Kallar på metoden för att räkna ut det samanlagda värdet av alla discar i bagen.
                        Console.ForegroundColor = ConsoleColor.Green; // Ändrar textfärgen till grån på värdet som skrivs ut.
                        Console.WriteLine("Den totala kostnade av dina discar är {0} kr", CalcDiscs()); // Skriver ut värdet genom att hämta retur värdet i metoden CalcDisc.
                        break;
                    case 5:
                        PrintDiscbag(); // Kallar på metoden för att skriva ut hela innehållet i din discbag.
                        break;
                    case 6:
                        EmptyDiscBag(); // Kallar på metoden för att tömma din bag och börja om.
                        break;
                    case 0:
                        Console.WriteLine("Programmet avslutas");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red; // ändrar textfärgen till röd om fel inmatning görs.
                        Console.WriteLine("Felaktig inmatning ");
                        break;
                }
            } while (menu != 0);
            DiscBagFull(); // Hindrar anvädaren från att lägga till flera discar så bagen är full.
        }
        public void AddDisc()
        {
            if (antal_discar < discBag.Length - 1) /* OM antalet discar är mindre än antalet platser i vektorn
                så kör denna meny. */
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
                            Console.WriteLine("0: Du backade tillbaka till föregående meny");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Felaktig inmatning ");
                            break;
                    }

                } while (temp != 0);
            }
        }

        public void AddDriver() // Metod för att lägga till en driver.
        {
            int temp = 0; // variabel som håller read på vilket menyval som gjorts.
            do
            {
                DiscBagFull(); // OM discbagen är full kör denna metod.
                Console.ResetColor();
                Console.WriteLine("\nVar god välj driver");
                Console.WriteLine("1: Freedom");
                Console.WriteLine("2: Saint Pro");
                Console.WriteLine("3: Star Destroyer");
                Console.WriteLine("0: Backa tillbaka till föregående meny");
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
                        Console.WriteLine("0: Du backade tillbaka till föregående meny");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Felaktig inmatning ");
                        break;
                }
            }

            while (temp != 0);
        }
        public void AddMidRange() // Metod för att lägga till en MidRange.
        {

            int temp = 0; // variabel som håller read på vilket menyval som gjorts
            do
            {
                DiscBagFull(); // OM discbagen är full kör denna metod.
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
                        Console.WriteLine("0: Du backade tillbaka till föregående meny");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Felaktig inmatning ");
                        break;
                }
            } while (temp != 0);
        }
        public void AddPutter() // Metod för att lägga till en putter.
        {
            int temp = 0; // variabel som håller read på vilket menyval som gjorts
            do
            {
                DiscBagFull(); // OM discbagen är full kör denna metod.
                Console.ResetColor();
                Console.WriteLine("\nVar god välj putter");
                Console.WriteLine("1: Judge");
                Console.WriteLine("2: Mercy");
                Console.WriteLine("3: Aviar");
                Console.WriteLine("0: Backa tillbaka till föregående meny");
                int.TryParse(Console.ReadLine(), out temp); // Fångar upp om man slagit in en bokstav eller en felaktigt siffra.
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
                        Console.WriteLine("0: Du backade tillbaka till föregående meny");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Felaktig inmatning ");
                        break;
                }
            } while (temp != 0);
        }
       
        public void SubDisc()
        {
            // Denna kod fungerar inte som den ska tyvärr.
            //for (int i = 0; i < discBag.Length; i++)
            //{
            //    discBag[i] = antal_discar;
            //}
            //int indexToRemove = 0;
            //discBag = discBag.Where((source, index) => index != indexToRemove).ToArray();
        }
        public void SwapDisc()
        {
            // Har inte fått till detta alls. Denna kod byter bara plats på 2 element. 
            //var Temp = 0;
            //Item Temp = discBag[2];
            //discBag[2] = discBag[3];
            //discBag[3] = Temp;
            //Console.WriteLine("Du bytte en disc");
        }
        //// Print Metod ////
        public void PrintDiscbag() // Metod för att skriva ut innehållet i bagen.
        {
            int count = 0;
            for (int i = 0; i < discBag.Length; i++)
            {
                if (discBag[i] != null) // OM INTE elementen i vektor är null GÖR detta.
                {
                    Console.WriteLine("Index : {0} {1}", i, discBag[i]); // Skriver ut vad du lagt till i din bag.
                    count++;
                }
                else // Annars skriv ut detta.
                {
                    Console.WriteLine("\nTom plats");
                }
            }
            Console.WriteLine("\nDu har {0} discar i din  discbag.", count); // Skiver ut antal discar i bagen.
            Console.WriteLine("Du har {0} platser i din discbag.", discBag.Length); // Skriver ut antal platser i bagen.
        }

        public double CalcDiscs() // Metod för att räkna ut det samanlagda värdet av alla discar.
        {
            double price = 0; // variable för att hålla reda på priset på alla discar.
            foreach (var antal_discar in discBag)
            {
                if (discBag != null && antal_discar != null) /*  OM det INTE är ett tomt element i vektorn 
                    och variablen som håller rätt på antal discar INTE är null. 
                    Lägg ihop egenskapen price i varje element.*/
                    price += antal_discar.get_price(); // Lägger ihop väderdet av alla discar genom att kalla på varibeln get_price i klassen Disc.
            }
            return price; // Returnera variablen price.
        }

        public void EmptyDiscBag() // Metod för att tömma discbagen
        {
            for (int i = 0; i < discBag.Length; i++)
            {
                discBag[i] = null; // Sätt värdet null i alla vektorns element. 
            }
            antal_discar = 0;
        }
        public void DiscBagFull() // Metod för att meddela att discbagen är full.
        {
                if (antal_discar == 5) /* OM antal discar i bagen är samma som max antalet man kan ha i den.
                skriv ut detta. Och gör det med röd text färg. Byt sedan tillbaka till vit textfärg igen*/
            { 
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDin diskbag är full");
                Console.ResetColor();
                Console.WriteLine("\nVar god välj ett annat alternativ");
                Run(); // Återgår till hududmenyn
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
            // Skapar en konstruktor för att skapa ny instanser av klassen.
            protected Disc(string Make, string Type, string Name, double Price)
            {
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
            public double get_price() // variable som används för att räkna ihop summan av alla discar i metoden CalcDisc.
            {
                return price;
            }
            ///////////////// Konstruktor för en ny disc av typen driver ////////////
        }
        class DiscDriver : Disc
        {
            // Skaper en konstruktor för att skapa nya instanser av klassen DiscDriver.
            public DiscDriver(string Make, string Type, string Name, double Price) : base(Make, Type, Name, Price)
            { 
            }
        }
        class MidRange : Disc
        {
            // // Skaper en konstruktor för att skapa nya instanser av klassen MidRange.
            public MidRange(string Make, string Type, string Name, double Price) : base(Make, Type, Name, Price)
            {
            }
        }
        class Putter : Disc
        {
            // Skaper en konstruktor för att skapa nya instanser av klassen Putter.
            public Putter(string Make, string Type, string Name, double Price) : base(Make, Type, Name, Price)
            {
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