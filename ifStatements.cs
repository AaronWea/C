using System;

namespace ifStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is the weather sunny today?");

            string sWeather = Console.ReadLine();

            if (sWeather == "yes")
            {
                Console.WriteLine("Have fun");
            }
            else
            {
                Console.WriteLine("Unlucky");
            }


            Console.WriteLine("What was your test score?");

            int Score = int.Parse(Console.ReadLine());

            if (Score <= 25) 
            {
                Console.WriteLine("You failed.");
            }
            else if (Score >= 25)
            {
                Console.WriteLine("You passed!");
            }





            Console.ReadLine();


        }
    }
}
