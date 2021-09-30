using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int correctNum = random.Next(1, 11);

            int i = 0;
            while(i < 3)
            {
                Console.WriteLine("Vali number 1-10");
                int userNum = Convert.ToInt32(Console.ReadLine());

                if(userNum == correctNum)
                {
                    Console.WriteLine("Palju õnne, oled võitnud");
                    break; //(i = 3)
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Proovi uuesti. {3-i} katset on alles!");
                }
            }
        }
    }
}
