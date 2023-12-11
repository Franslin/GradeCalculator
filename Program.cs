using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runCalculator = false;

            Console.WriteLine("Vill du beräkna betyg för en elev? Ja/Nej");
            string answer = Console.ReadLine().ToLower();
            if (answer == "ja") {
                runCalculator = true;
            }

            while (runCalculator)
            {
                Console.WriteLine("Mata in elevens poäng");
                int score = Convert.ToInt32(Console.ReadLine());
                string grade;

                if (score >= 90)
                    grade = "A";
                else if (score >= 80 && score <= 89)
                    grade = "B";
                else if (score >= 70 && score <= 79)
                    grade = "C";
                else if (score >= 60 && score <= 69)
                    grade = "D";
                else if (score >= 50 && score <= 59)
                    grade = "E";
                else
                    grade = "F";

                Console.WriteLine($"Elevens betyg är: {grade}");

                Console.WriteLine("Vill du beräkna betyg för en till elev? Ja/Nej");
                string answer2 = Console.ReadLine().ToLower();
                if (answer2 == "ja")
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Programmet är nu avslutat");
                    runCalculator = false;
                }
            }


            


        }
    }
}
