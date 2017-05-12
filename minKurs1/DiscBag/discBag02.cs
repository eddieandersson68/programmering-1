using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscBag
{
    class MinDiscBag
    {
        const int ARRAY_SIZE = 25; // Ett konstant värde Så att jag bara har ett ställe att ändra på om jag behöver öa lr minska min vektor.
        private int[] discBag = new int[ARRAY_SIZE]; //Jobbar ni med struct (ev betyg C) eller klass för soda (betyg A) så är det inte "string" som är datatyp här
        private int antal_discar = 0; //Håller reda på antal discar

        // En vektor för att hålla 5 olika typer av drivers 
        //int[] midrange = new int[5]; // == antalet discar som jag lagt till av denna typ
        //int[] putter = new int[5]; // == antalet discar som jag lagt till av denna typ
        //(Betyg A): En konstruktor kan ni använda för Sodacrate men det är inget krav.
        //(Betyg A): Däremot ska ni använda en konstruktor för klassen "Soda"
        //////////////////////////////////////////////////
        //private bool menu = true;
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
                        //Console.WriteLine("\n"+"Du lade till en "+disc.type+" av märket "+ disc.make+":" +" som heter "+disc.name+" den kostar " +disc.price+ "kr");
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
                        //menu = false;
                        break;
                }
            } while (menu != 0);

        }
        public void AddDisc()
        {
            int temp = 0;
            do
            //if (antal_discar < 2)
            //{
            //    Console.WriteLine("Skriv namnet på den disc du vill lägga till \n");
            //    discBag[antal_discar] = Console.ReadLine();
            //    antal_discar++; ////Lägg till disc
            //}
            //else
            //    Console.WriteLine("\n Discbagen är full!");
            //int temp = 0;
            //do
            {
                Console.WriteLine("Var god välj disk typ");
                Console.WriteLine("1: Driver");
                Console.WriteLine("2: Midrange");
                Console.WriteLine("3: Putter");
                Console.WriteLine("0: Backa tillbka till föregående meny");
                //Console.Clear();
                int.TryParse(Console.ReadLine(), out temp);
                //for (int i = 0; i < discBag.Length; i++)
                //{
                //    discBag[i] = antal_discar;
                //}
                //disc = Console.ReadLine();
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

            //while (temp != 0);

            //for (int j = 0; j > discBag.Length; j++)
            //{
            //    if (antal_discar == 2)
            //    {
            //        
            //    }
            //    else
            //    {
            //        antal_discar++;
            //        break;
            //    }

            //}
        }
        public void AddDriver()

        {
            DiscDriver Freedom = new DiscDriver(Lattitude_64, driver, Freedom, 169);
            Console.WriteLine(Freedom);
            if (antal_discar != 25)
            {
                antal_discar++;
            }
            else
            {
                Console.WriteLine("Bagen är full");
            }

            for (int j = 0; j < discBag.Length; j++)
            {
                discBag[j] = antal_discar;

            }


            //for (int j = 0; j > discBag.Length; j++)
            //    if (antal_discar == 2)
            //    {
            //        Console.WriteLine("Bagen full");
            //    }
            //    else
            //    {
            //        antal_discar++;
            //        break;
            //    }

            //Driver freedom = new Driver();
            //Console.WriteLine(Freedom.ToString());
            //Driver Lat = new Driver();
            //Console.WriteLine("Lattitude 64, Driver, Freedom, 169kr");
            //drivers[0] = new DiscDriver("Lattitude", "Driver", "Freedom", 169);
            //drivers[1] = new DiscDriver("Lattitude", "Driver", "Saint Pro", 189);
        }
        public void SubDisc()
        {
            //Console.WriteLine("vilken disk vill du ta bort? ");
            //discBag.Add= string name = (Console.ReadLine());  
            //if (discBag[0]= name)         
            //{
            int indexToRemove = 0;
            discBag = discBag.Where((source, index) => index != indexToRemove).ToArray();
            //}
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
            int count = 0;
            foreach (int antal_discar in discBag) //För varje disc plats i bagen kollar vi,
            {
                if (antal_discar != 0) count += 1; //Om det faktiskt är en disc i bagen och inte en tom plats.
            }
            //foreach (int antal_discar in discBag)
            //{
            Console.WriteLine("Du har en {0}  discs i din discbag.", antal_discar);
            //}
            Console.WriteLine("Du har {0}  discar i din discbag.", count);
            Console.WriteLine(discBag[0].ToString());
            //Console.WriteLine("You have {0} discs in your discbag.", discBag.Length);



            //foreach (string temp in discBag)
            //Console.WriteLine(temp);
            //kod här
            //Missa inte hjälpkoden som finns i projektbeskrivningen
            //Där beskrivs hur man löser det med tomma positioner i vektorn
        }
        public void CalcDiscs()
        {

            //Console.WriteLine("Räkna ut totalsumman av alla diskar "+ disc.price + disc. );
            //kod här
            //Tänk på att inte räkna med tomma positioner i vektorn
        }
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
        // Abstract class för discar.
        public abstract class Disc
        {
            ////private disc[] drivers;
            protected string make;
            protected string type;
            protected string name;
            protected int price;

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
            //public Disc()
            //{
            //    Make = "Lattitude";
            //    Type = "Driver";
            //    Name = "Freedom";
            //    Price = 169;
            //}

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
            protected Disc(string Make, string Type, string Name, int Price)
            {
                Console.WriteLine("Basklass");
            }

        }
        class DiscDriver : Disc
        {
            public DiscDriver(string Lattitude_64, string driver, string Freedom, int pris ) : base(Lattitude_64, driver, Freedom, 169)
            {
            Console.WriteLine("Ärvande klass");
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

    }
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
