using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1-10
            //kasutaja peab numbri ära arvama
            //kui kasutaja arvab numbri ära, siis on ta võitnud
            //katsete arv on piiramatu

            Random random = new Random();
            int correctNum = random.Next(1, 11);
            bool loopActive = true;


            while (loopActive)
            {
                Console.WriteLine("Vali number 1-10:");
                int userNum = Convert.ToInt32(Console.ReadLine());

                if (correctNum == userNum)
                {
                    Console.WriteLine("Palju Õnne, Oled võitnud:");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Vale vastus, proovi uuesti:");
                }
            }
            Console.WriteLine("Kena päeva!");
            
           


            
        }
    }
}
