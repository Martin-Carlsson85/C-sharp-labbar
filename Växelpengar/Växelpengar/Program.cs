using System;

namespace Växelpengar
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalSum = 0;
            int sum = 0;
            int sumAfterRound = 0;
            decimal earRounding = 0;
            int change = 0;

            while (true)
            {
                try
                {
                    Console.Write("Ange totalsumman för köpet!");
                    totalSum = decimal.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Felaktig totalsumma!");
                    Console.ResetColor();
                } 
            }
            sumAfterRound = (int)Math.Round(totalSum, 2);

            while (true)
            {
                try
                {
                    Console.Write("Ange erhållet belopp från kund: ");
                    sum = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erhållet belopp är felaktigt");
                    Console.ResetColor();
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
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du har betalt för lite pengar");
                    Console.ResetColor();
                    break;
                }
                
            }

            earRounding = sumAfterRound - totalSum;
            change = sum - Convert.ToInt32(totalSum);


            if(totalSum < sum)
            {
                Console.WriteLine("\nKvitto");
                Console.WriteLine("--------------------");
                Console.WriteLine("Totalt: {0}", totalSum);
                Console.WriteLine("Öresavrunding: {0}", Math.Round(earRounding, 2));
                Console.WriteLine("Att betala: {0}", sumAfterRound);
                Console.WriteLine("Kontant {0}", sum);
                Console.WriteLine("Tillbaka: {0}", change);
                Console.WriteLine("---------------------");

                int fivehundred = change / 500;
                int cash = change % 500;

                int hundred = cash / 100;
                cash = cash % 100;

                int fifty = cash / 50;
                cash = cash % 50;

                int twenty = cash / 20;
                cash = cash % 20;

                int ten = cash / 10;
                cash = cash % 10;

                int one = cash / 1;

                Console.WriteLine("500-lappar           : {0})", fivehundred);
                Console.WriteLine("100-lappar           : {0})", hundred);
                Console.WriteLine("50-lappar            : {0})", fifty);
                Console.WriteLine("10-krona             : {0})", ten);
                Console.WriteLine("1-krona              : {0})", one);
            }
            else
            {
                Console.WriteLine("Inget kvitto visas då inget köp kunde genomföras");
            }

        }
    }
}
