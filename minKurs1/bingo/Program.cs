using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bingo
{
    class GetUserNrs

    {
        public static int[] GetUserGuesses()
        {
            int userNr = 0;
            int[] UserBingoNrs = new int[4];
            Console.WriteLine("Skriv in dina 10 tal: ");
            for (int i = 0; i < UserBingoNrs.Length; i++)
            {
                try
                {
                    int.TryParse(Console.ReadLine(), out userNr);
                    //if (!UserNrOK)
                }
                catch
                {
                    Console.WriteLine("Ditt tal är inte mellan 1-25 eller så slog du in andra tecken ");
                }
                if (userNr > 0 && userNr < 26)
                {

                    UserBingoNrs[i] = userNr;
                }
                else
                {
                    Console.WriteLine("Ditt tal är inte mellan 1-25");
                    i--;
                }


            }
            //bool found = false;
            int correctCount = 0;
            int[] RandomNrs = new int[4];
            Random rnd = new Random();
            for (int i = 0; i < RandomNrs.Length; i++)
            {
                RandomNrs[i] = rnd.Next(1, 25);

                //for (int j = 0; j < RandomNrs.Length; j++)
                //{

                    if (UserBingoNrs.Contains(RandomNrs[i]))
                    //if (RandomNrs[j] == UserBingoNrs[i])
                    {
                        correctCount++;
                        //found = true;
                    }
                    //if (found == true)
                    //{
                        
                    //}
                //}
            }
            Console.WriteLine("User nrs [{0}]", string.Join(", ", UserBingoNrs));
            Console.WriteLine("Random nrs [{0}]", string.Join(", ", RandomNrs));
            Console.WriteLine("Du fick: " + correctCount + "poäng");

            Console.ReadKey();

            return UserBingoNrs;
        }

    }
    //}
    //public static int[] GetRandomUniqueNumbers(int size, int minValue, int maxValue)
    //{
    //    return Enumerable.Range(minValue, maxValue).OrderBy(x => rnd.Next()).Take(size).ToArray();
    //}

    //public static int[] CheckCorrectAnswers(int[] userinput, int[] randomNumbers)
    //{
    //    // Loopa igenom userinput
    //    // gör en metod som kollar om siffran är i randomnumbers
    //    List<int> correctAnswers = new List<int>()
    //for (int i = 0; i < userinput.length; i++)
    //    {
    //        if (containsnumberinlist(userinput[i], randomnumbers))
    //        {
    //            correctAnswers.Add(userinput[i]);
    //        }
    //    }
    //    return correctAnswers
    //}


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till bingo spelet, skriv in 10 tal mellan 1 och 25 ");
            GetUserNrs.GetUserGuesses();


            //här ska du tilldela resultatet till en variabel
            // var userGuesses = GetUserGuesses();



            //gör en sån här metod också
            // var randomNumbers = GetRandomUniqueNumbers(7,1,25)

            //sen gör du en metod
            // var correctnr = CheckCorrectAnswers(userGuesses,randomNumbers);

            // då kan du få ut en lista med rätta nummer.
            //GetUserNrs.Checker();

            //        public static int[] Checker()
            //{


        }

    }
}


//for (int i = 0; i < UserBingoNrs.Length; i++)
//    for (int j = 0; j < RandomNrs.Length; j++)
//    {
//        string comp1 = array1[i];
//        string comp2 = array2[j];
//        if (comp1 == comp2)
//        {
//            //Do something

//}
//int correctCount = 0;
//foreach (var number in UserBingoNrs)
//{
//    foreach (var exists in UserBingoNrs)
//    {
//        if (number == exists)
//        {
//            correctCount++;
//        }
//    }
//}



/*  class DrawLotteryNrs
{
   public static int[] DrawNrs(int randNr)
   {
       int correct = 0;
       bool found = false;

       int[] RandomNrs = new int[7];
       Random rnd = new Random();
       for (int j = 0; j < RandomNrs.Length; j++)
       {
           RandomNrs[j] = rnd.Next(1, 25);

       for (int i = 0; i < RandomNrs.Length; i++)
       {
           if (RandomNrs[i] == UserBingoNrs
           {
               found = true;
           }

           if (found == true)
           {
               correct++;
           }
       }

   }
} */

//return randNr = rnd.Next(1, 25);

//if (GetUserNrs.GetUserInput ;)

//int num = 0;
//int randNr = 0;
//int numberAmount = 0;
//int userNrs;
//Console.WriteLine("Skriv in 10 tal mellan 1 och 25 ");

//Console.Write("Skriv in x antal tal, så ska jag räkna ut medelvärdet av dem ");
//string str = (Console.ReadLine());
//int size = Convert.ToInt32(str);



//int[] userNrs = new int[size]; // skapa ny vektor med [size] platser
//for (int i = 0; i < userNrs.Length; i++) // Use Length property rather than the 10 magic number again
//{
//    Console.Write("Skriv in tal  " + i + ": ");
//    str = Console.ReadLine();
//    int element = Convert.ToInt32(str);
//    userNrs[i] = element;
//    Console.WriteLine(userNrs[i]);
//}
// räkna ut summan
//int sum = 0;
//for (int i = 0; i < userNrs.Length; i++)
//    sum = sum + userNrs[i];
//Console.WriteLine("Medelvärdet för alla element är: " + sum / userNrs.Length);


//num = DrawLotteryNrs.DrawNrs(randNr);
//Console.WriteLine(num);
//Console.ReadKey();



//Console.WriteLine("Skriv in 10 tal mellan 1 och 25 ");
//userNrs = int.Parse(Console.ReadLine());
//        Console.WriteLine(i + userNr[i]);



//Console.WriteLine("Skriv in 10 tal mellan 1 och 25 ");

//Console.WriteLine(userNrs);

//Console.WriteLine("num {0}", (randNr));

// skapa vektorn
//int[] anvTal = new int[10];









