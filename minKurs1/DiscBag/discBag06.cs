using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscBag
{
    class MinDiscBag
    {
        Disc[] discBag = new Disc[5];
        //const int ARRAY_SIZE = 3; // Ett konstant värde Så att jag bara har ett ställe att ändra på om jag behöver öa lr minska min vektor.
        //private int[] discBag = new int[ARRAY_SIZE]; //Jobbar ni med struct (ev betyg C) eller klass för soda (betyg A) så är det inte "string" som är datatyp här
        private int antal_discar = 0; //Håller reda på antal discar
        private int[] prices = new int[3];
        float sum =0;
        // En vektor för att hålla 5 olika typer av drivers 
        //int[] midrange = new int[5]; // == antalet discar som jag lagt till av denna typ
        //int[] putter = new int[5]; // == antalet discar som jag lagt till av denna typ
        //(Betyg A): En konstruktor kan ni använda för Sodacrate men det är inget krav.
        //(Betyg A): Däremot ska ni använda en konstruktor för klassen "Soda"
        //////////////////////////////////////////////////
        //private bool menu = true;
        public void Run()
        {

            int menu = 0; // variabel som håller read på vilket menyval som gjorts
            do
            {
                Console.WriteLine("\t");
                Console.WriteLine("\n" + "Välkommen till din alldeles egna Discbags simulator ");
                Console.WriteLine("var god välj ett alternativ \n");
                Console.WriteLine("1. Lägg till en disc");
                Console.WriteLine("2. Ta bort en disc");
                Console.WriteLine("3. Byt ut en disc");
                Console.WriteLine("4. Räkna ut det sammanlagda värdet av din discbag");
                Console.WriteLine("5. Skriv ut innehållet i din discbag");
                Console.WriteLine("0. Avsluta programmet");
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
                        break;
                    case 5:
                        PrintDiscbag();
                        break;
                    case 0:
                        Console.WriteLine("Programmet avslutas");
                        break;
                    default:
                        Console.WriteLine("Felaktig inmatning ");
                        break;
                }
            } while (menu != 0);

        }
        public void AddDisc()
        {
            int temp = 0; // variabel som håller read på vilket menyval som gjorts
            do
            {
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
                        Console.WriteLine("Felaktig inmatning ");
                        break;
                }

            } while (temp != 0);
        }
        public void AddDriver()
        {
            if (antal_discar >= 3)
            {
                Console.WriteLine("\nDin diskbag är full");
                Console.WriteLine(antal_discar);

            }
            int temp = 0; // variabel som håller read på vilket menyval som gjorts
            do
            {
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
                        //DiscDriver d1 = new DiscDriver("Dynamic Discs", "Driver", "Freedom", 189);
                        //discBag[0] = d1;
                        Console.WriteLine(discBag[0]);
                        //antal_discar++;

                        break;
                    case 2:
                        DiscDriver d2 = new DiscDriver("Lattitude 64", "Driver", "Saint Pro", 169);
                        discBag[1] = d2;
                        Console.WriteLine(d2);
                        antal_discar++;
                        break;
                    case 3:
                        DiscDriver d3 = new DiscDriver("Innova", "Driver", "Star Destroyer", 159);
                        discBag[2] = d3;
                        Console.WriteLine(d3);
                        antal_discar++;
                        break;
                    case 0:
                        Console.WriteLine("0: Du backade tillbka till föregående meny");
                        break;
                    default:
                        Console.WriteLine("Felaktig inmatning ");
                        break;
                }
            } while (temp != 0);
        }
        public void AddMidRange()
        {
            if (antal_discar >= 3)
            {
                Console.WriteLine("\nDin diskbag är full");
                Console.WriteLine(antal_discar);

            }
            int temp = 0; // variabel som håller read på vilket menyval som gjorts
            do
            {
                Console.WriteLine("\nVar god välj midrange");
                Console.WriteLine("1: Truth");
                Console.WriteLine("2: Core");
                Console.WriteLine("3: Cobra");
                Console.WriteLine("0: Backa tillbka till föregående meny");


                int.TryParse(Console.ReadLine(), out temp); // fångar upp om man slagit in en bokstav eller en felaktigt siffra.
                switch (temp)
                {
                    case 1:
                        MidRange m1 = new MidRange("Dynamic Discs", "Midrange", "Truth", 170);
                        discBag[3] = m1;
                        Console.WriteLine(m1);
                        antal_discar++;
                        break;
                    case 2:
                        MidRange m2 = new MidRange("Lattitude 64", "Midrange", "Core", 145);
                        discBag[4] = m2;
                        Console.WriteLine(m2);
                        antal_discar++;
                        break;
                    case 3:
                        MidRange m3 = new MidRange("Innova", "Midrange", "Cobra", 137);
                        discBag[5] = m3;
                        Console.WriteLine(m3);
                        antal_discar++;
                        break;
                    case 0:
                        Console.WriteLine("0: Du backade tillbka till föregående meny");
                        break;
                    default:
                        Console.WriteLine("Felaktig inmatning ");
                        break;
                }
            } while (temp != 0);
        }
        public void AddPutter()
        {
            if (antal_discar >= 3)
            {
                Console.WriteLine("\nDin diskbag är full");
                Console.WriteLine(antal_discar);

            }
            int temp = 0; // variabel som håller read på vilket menyval som gjorts
            do
            {
                Console.WriteLine("\nVar god välj putter");
                Console.WriteLine("1: Judge");
                Console.WriteLine("2: Mercy");
                Console.WriteLine("3: Aviar");
                Console.WriteLine("0: Backa tillbka till föregående meny");


                int.TryParse(Console.ReadLine(), out temp); // fångar upp om man slagit in en bokstav eller en felaktigt siffra.
                switch (temp)
                {
                    case 1:
                        Putter p1 = new Putter("Dynamic Discs", "Putter", "Judge", 173);
                        discBag[6] = p1;
                        Console.WriteLine(p1);
                        antal_discar++;
                        break;
                    case 2:
                        Putter p2 = new Putter("Lattitude 64", "Putter", "Mercy", 165);
                        discBag[7] = p2;
                        Console.WriteLine(p2);
                        antal_discar++;
                        break;
                    case 3:
                        Putter p3 = new Putter("Innova", "Putter", "Aviar", 147);
                        discBag[8] = p3;
                        Console.WriteLine(p3);
                        antal_discar++;
                        break;
                    case 0:
                        Console.WriteLine("0: Du backade tillbka till föregående meny");
                        break;
                    default:
                        Console.WriteLine("Felaktig inmatning ");
                        break;
                }
            } while (temp != 0);
        }

        //Driver freedom = new Driver();
        //Console.WriteLine(Freedom.ToString());
        //Driver Lat = new Driver();
        //Console.WriteLine("Lattitude 64, Driver, Freedom, 169kr");
        //drivers[0] = new DiscDriver("Lattitude", "Driver", "Freedom", 169);
        //drivers[1] = new DiscDriver("Lattitude", "Driver", "Saint Pro", 189);

        public void SubDisc()
        { 
            int indexToRemove = 0;
            discBag = discBag.Where((source, index) => index != indexToRemove).ToArray();
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
            int count = 0;
            foreach (var antal_discar in discBag)
            {
                if (antal_discar != null)
                    Console.WriteLine("{0} ", antal_discar);
                else
                    Console.WriteLine("\nTom plats");
            }
            for (int i = 0; i < antal_discar; i++)
                //foreach (int temp in discBag) //För varje disc plats i bagen kollar vi,
                if (antal_discar != 0) count += 1; //Om det faktiskt är en disc i bagen och inte en tom plats.
                else
                    Console.WriteLine("\n{0}Tom plats", count);
            {
                Console.WriteLine("Du har {0} discs i din discbag.", antal_discar);
            }
            Console.WriteLine("Du har {0} platser i din discbag.", discBag.Length);
            //Console.WriteLine(discBag[0].ToString());
        }
        public void CalcDiscs()
        {
            //sum += sum + Disc. discBag[];
            //Console.WriteLine(sum);
            //Tänk på att inte räkna med tomma positioner i vektorn
        }
        // Abstract class för discar.
        public abstract class Disc
        {
            // privata class egenskaper
            protected string make;
            protected string type;
            protected string name;
            protected double price;
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
    // public properties skrivs med Pascal case eller _name

    //int[] driver = new int[5]; // En vektor för att hålla 5 olika typer av drivers 
    //int[] midrange = new int[5]; // == antalet discar som jag lagt till av denna typ
    //int[] putter = new int[5]; // == antalet discar som jag lagt till av denna typ
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









/*public struct Soda 
{
   Siktar ni mot specifikt betyget C och inte vill göra en egen klass av Soda så kan det fungera bra med en struct istället som ni definierar här
   Den kan då tre olika värden för namn, pris, och dryckestyp. Då blir hela projektet roligare - såsom sortering och uträkning av pris
 * Denna struct del bortser ni ifrån helt om ni inte vill jobba med detta och då alltså specifikt för betyget C 
}*/
