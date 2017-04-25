using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscBag
{
    class MinDiscBag
    {

        private int[] discBag = new int[24]; //Jobbar ni med struct (ev betyg C) eller klass för soda (betyg A) så är det inte "string" som är datatyp här
        //private int antal_discar = 0; //Håller reda på antal discar
        // En vektor för att hålla 5 olika typer av drivers 
        //int[] midrange = new int[5]; // == antalet discar som jag lagt till av denna typ
        //int[] putter = new int[5]; // == antalet discar som jag lagt till av denna typ
        //(Betyg A): En konstruktor kan ni använda för Sodacrate men det är inget krav.
        //(Betyg A): Däremot ska ni använda en konstruktor för klassen "Soda"
        //////////////////////////////////////////////////
        public void Run()
        {
            int meny = 0;
            do
            {
                Console.WriteLine("\n" + "Välkommen till din alldeles egna Discbags simulator ");
                Console.WriteLine("var god välj ett alternativ ");
                Console.WriteLine("1. Lägg till en disc");
                Console.WriteLine("2. Ta bort en disc");
                Console.WriteLine("3. Byt ut en disc");
                Console.WriteLine("4. Räkna ut det samamlagda värdet av din discbag");
                Console.WriteLine("5. Skriv ut innehållet i din discbag");
                Console.WriteLine("0. Avsluta programmet");
                meny = int.Parse(Console.ReadLine());
                switch (meny)
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
                        break;
                }
            } while (meny != 0);
        }


        class DiscDriver
        {
            //private disc[] drivers;
            private string make;
            private string type;
            private string name;
            private DiscDriver[] drivers;
            private int price;
            ///////////////// Konstruktor för en ny disc av typen driver ////////////
            public DiscDriver(string Make, string Type, string Name, int Price)
            {
                make = Make;
                Type = type;
                name = Name;
                price = Price;
                drivers = new DiscDriver[5];
            }

            // public properties skrivs med Pascal case eller _name
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
            //int[] driver = new int[5]; // En vektor för att hålla 5 olika typer av drivers 
            //int[] midrange = new int[5]; // == antalet discar som jag lagt till av denna typ
            //int[] putter = new int[5]; // == antalet discar som jag lagt till av denna typ
            public void AddDriver()
            {
                drivers[0] = new DiscDriver("Lattitude", "Driver", "Freedom", 169);
                drivers[1] = new DiscDriver("Lattitude", "Driver", "Saint Pro", 189);
            }
            class DiscMidrange
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
            }
            //Här ska menyn ligga för att göra saker
            //Jag rekommenderar switch och case här med en loop
            //I del 1 av filmerna för slutprojektet kodar jag en switch case

            
            /*Metod för att lägga till en disc
			Om ni har information om både pris, läsktyp och namn
			kan det vara läge att presentera en meny här där man kan
			välja på förutbestämda läskflaskor. Då kan man också rätt enkelt
			göra ett val för att fylla läskbacken med slumpade flaskor
			*/
            
        }
        public void AddDisc()
        {
            int temp = 0;
            Console.WriteLine("Var god välj disk typ");
            Console.WriteLine("1: Driver");
            Console.WriteLine("2: Midrange");
            Console.WriteLine("3: Putter");
            switch (temp)
            {
                case 1:
                    //AddDriver();
                    break;
                case 2:
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Felaktig inmatning ");
                    break;
            }
            


        }
        public void SubDisc()
        {
            Console.WriteLine("Du bort en disc");
        }
        public void SwapDisc()
        {
            Console.WriteLine("Du bytte en disc");
        }
        public void PrintDiscbag()
        {
            Console.WriteLine(discBag[0].ToString());
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

/*public struct Soda 
{
   Siktar ni mot specifikt betyget C och inte vill göra en egen klass av Soda så kan det fungera bra med en struct istället som ni definierar här
   Den kan då tre olika värden för namn, pris, och dryckestyp. Då blir hela projektet roligare - såsom sortering och uträkning av pris
 * Denna struct del bortser ni ifrån helt om ni inte vill jobba med detta och då alltså specifikt för betyget C 
}*/
