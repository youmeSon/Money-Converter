using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter an amount to convert to notes and coins:");
            double moneyInput = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"£{moneyInput} is equal to...");
            // Convert to Paper
            int twentyValue = 20;
            int tenValue = 10;
            int fiveValue = 5;
            int twoCoinValue = 2;
            int oneCoinValue = 1;
            double fiftyPenceValue = 0.5;
            double twentyPenceValue = 0.2;
            double tenPenceValue = 0.1;
            double fivePenceValue = 0.05;
            double twoPenceValue = 0.02;
            double onePennyValue = 0.01;
            // paper
            double twentyPound = Math.Floor(moneyInput / twentyValue);
            double leftover = moneyInput % twentyValue;
            double tenPound = Math.Floor(leftover / tenValue);
            leftover = Math.Round(leftover % tenValue, 2);
            double fivePound = Math.Floor(leftover / fiveValue);
            leftover = Math.Round(leftover % fiveValue, 2);
            //  coins
            double twoPound = Math.Floor(leftover / twoCoinValue);
            leftover = Math.Round(leftover % twoCoinValue, 2);
            double onePound = Math.Floor(leftover / oneCoinValue);
            leftover = Math.Round(leftover % oneCoinValue, 2);
            double fiftyPence = Math.Floor(leftover / fiftyPenceValue);
            leftover = Math.Round(leftover % fiftyPenceValue, 2);
            double twentyPence = Math.Floor(leftover / twentyPenceValue);
            leftover = Math.Round(leftover % twentyPenceValue, 2);
            double tenPence = Math.Floor(leftover / tenPenceValue);
            leftover = Math.Round(leftover % tenPenceValue, 2);
            double fivePence = Math.Floor(leftover / fivePenceValue);
            leftover = Math.Round(leftover % fivePenceValue, 2);
            double twoPence = Math.Floor(leftover / twoPenceValue);
            leftover = Math.Round(leftover % twoPenceValue, 2)*100;
           



            // console
            Console.WriteLine($"Twenty Pounds: {twentyPound}");
            Console.WriteLine($"Ten Pounds: {tenPound}");
            Console.WriteLine($"Five Pounds: {fivePound}");
            Console.WriteLine($"Two Pounds: {twoPound}");
            Console.WriteLine($"One Pounds: {onePound}");
            Console.WriteLine($"Fifty Pences: {fiftyPence}");
            Console.WriteLine($"Twenty Pences: {twentyPence}");
            Console.WriteLine($"Ten Pences: {tenPence}");
            Console.WriteLine($"Five Pences: {fivePence}");
            Console.WriteLine($"Two Pences: {twoPence}");
            Console.WriteLine($"One Penny: {leftover}");
        }
    }
}
