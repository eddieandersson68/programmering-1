/*2016-05-12
Detta kodskal kan upplevas väldigt omfattande. Om ni vill använda det så börja med att kopiera över koden till er utvecklingsmiljö som SharpDevelop.
Var noggranna med att "namespace" är samma. Det enklaste är att ni startar ett nytt projekt som heter "sodacrate" som sedan kopierar över rubbet
Därefter kan ni ta bort alla metoder ni inte ska jobba med samt skala bort kommentarer när ni läst dom.

*/


/*Hjälpkod för att komma igång
 * Notera att båda klasserna är i samma fil för att det ska underlätta.
 * Om programmet blir större bör man ha klasserna i separata filer såsom jag går genom i filmen
 */
using System;

namespace sodacrate
{
    /*public struct Soda 
    {
       Siktar ni mot specifikt betyget C och inte vill göra en egen klass av Soda så kan det fungera bra med en struct istället som ni definierar här
       Den kan då tre olika värden för namn, pris, och dryckestyp. Då blir hela projektet roligare - såsom sortering och uträkning av pris
     * Denna struct del bortser ni ifrån helt om ni inte vill jobba med detta och då alltså specifikt för betyget C 
    }*/

	class Sodacrate
	{
		private int [] flaskor = new int[24]; //Jobbar ni med struct (ev betyg C) eller klass för soda (betyg A) så är det inte "string" som är datatyp här
		private int antal_flaskor = 0; //Håller reda på antal flaskor

		//(Betyg A): En konstruktor kan ni använda för Sodacrate men det är inget krav.
		//(Betyg A): Däremot ska ni använda en konstruktor för klassen "Soda"
		
		public void Run()
		{
			Console.WriteLine("Welcome to the awesome Sodacrate-simulator");
			//Här ska menyn ligga för att göra saker
			//Jag rekommenderar switch och case här med en loop
            //I del 1 av filmerna för slutprojektet kodar jag en switch case
		}
		
		public void add_soda()
		{
			/*Metod för att lägga till en läskflaska
			Om ni har information om både pris, läsktyp och namn
			kan det vara läge att presentera en meny här där man kan
			välja på förutbestämda läskflaskor. Då kan man också rätt enkelt
			göra ett val för att fylla läskbacken med slumpade flaskor
			*/
		}
		
		public void print_crate()
		{
			//kod här
			//Missa inte hjälpkoden som finns i projektbeskrivningen
			//Där beskrivs hur man löser det med tomma positioner i vektorn
		}
		
		public int calc_total()
		{
			//kod här
			//Tänk på att inte räkna med tomma positioner i vektorn
		}
		
		public void find_soda()
		{
			//Betyg C
			//Beskrivs i läroboken på sidan 147 och framåt (kodexempel på sidan 149)
			//Man ska kunna söka efter ett namn
			//Man kan använda string-metoderna ToLower() eller ToUpper() 
		}
		
		public void sort_sodas()
		{
			//Betyg A-C
			//Beskrivs i läroboken på sidan 147 och framåt (kodexempel på sidan 159)
			//Man ska kunna sortera vektorn med flaskor och med bubble sort
            //Det är mycket svårt att sortera efter bokstavsordning - är inte flaskorna egna objekt utan bara strängar...
            //... går det bra att sortera efter längden på namnet istället. 
		}
	}
    class Soda
    {

    }
	
	class Program
	{
		public static void Main(string[] args)
		{
			//Skapar ett objekt av klassen Sodacrate som heter sodacrate
			var sodacrate = new Sodacrate();
			sodacrate.Run();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}