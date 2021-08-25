using System;

namespace DevYou_Week2_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise One
            Console.Write("Enter Weight: ");
            double weight = int.Parse(Console.ReadLine());

            Console.Write("Enter Middle Intitial: ");
            char middleInitial = char.Parse(Console.ReadLine());

            Console.WriteLine($"Weight is {weight}");
            Console.WriteLine($"Middle initial is {middleInitial}");

            //Exercise Two
            double firstNumber = 10;
            double secondNumber = 25;

            double sum = firstNumber + secondNumber;
            double difference = firstNumber - secondNumber;
            double product = firstNumber * secondNumber;
            double quotient = firstNumber / secondNumber;

            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine($"The difference is {difference}");
            Console.WriteLine($"The product is {product}");
            Console.WriteLine($"The quotient is {quotient}");

            //Challenge
            Console.Write("Enter First Number: ");
            double userFirstNum = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double userSecondNum = int.Parse(Console.ReadLine()); ;

            double calcSum = userFirstNum + userSecondNum;
            double calcDifference = userFirstNum - userSecondNum;
            double calcProduct = userFirstNum * userSecondNum;
            double calcQuotient = userFirstNum / userSecondNum;

            Console.WriteLine($"The sum is {calcSum}");
            Console.WriteLine($"The difference is {calcDifference}");
            Console.WriteLine($"The product is {calcProduct}");
            Console.WriteLine($"The quotient is {calcQuotient}");

            Console.ReadLine();
        }
    }
}
