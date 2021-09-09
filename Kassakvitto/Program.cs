using System;

namespace Kassakvitto
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalSum;
            int sum;
            int sumAfterRound;

            while (true)
            {
                try
                {
                    Console.WriteLine("Ange totalsumman för köpet:");
                    totalSum = double.Parse(Console.ReadLine());
                    break;
                    
                }
                catch
                {
                    Console.WriteLine("Felaktig totalsumma!");
                }
            }
            sumAfterRound = (int)Math.Round(totalSum);

            while (true)
            {
                try
                {
                    Console.WriteLine("Ange erhållet belopp från kund:");
                    sum = int.Parse(Console.ReadLine());
                    break;
                    
                }
                catch
                {
                    Console.WriteLine("Erhållet belopp är felaktigt");
                }
            }

            while (true)
            {
                try
                {
                    if (totalSum > sum)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        break;
                    }

                }

                catch
                {
                    Console.WriteLine("Du har betalt för lite pengar");
                    break;
                }
            }

            Console.WriteLine(totalSum + sumAfterRound);
           
        }
    }
}
