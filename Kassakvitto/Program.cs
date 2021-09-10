using System;

namespace Kassakvitto
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalSum = 0;
            int sum = 0;
            int sumAfterRound = 0;
            double earRounding = 0;
            int change = 0;

            while (true)
            {
                try
                {
                    Console.Write("Ange totalsumman för köpet: ");
                    totalSum = double.Parse(Console.ReadLine());
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

            Console.WriteLine("\nKVITTO");
            Console.WriteLine("---------------------");
            Console.WriteLine("Totalt: {0}", totalSum);
            Console.WriteLine("Öresavrundning: {0}", Math.Round(earRounding, 2));
            Console.WriteLine("Att betala: {0}", sumAfterRound);
            Console.WriteLine("Kontant: {0}", sum);
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
            
            Console.WriteLine("500-lappar          : {0}", fivehundred);
            Console.WriteLine("100-lappar          : {0}", hundred);
            Console.WriteLine("50-lappar           : {0}", fifty);
            Console.WriteLine("20-lappar           : {0}", twenty);
            Console.WriteLine("10-lappar           : {0}", ten);
            Console.WriteLine("10-lappar           : {0}", one);
        }
    }
}

