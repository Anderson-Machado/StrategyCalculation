using System;

namespace StrategyCalculation
{
    class Program
    {
        static void Main(string[] args)
        {

            CalculateClient minusClient = new CalculateClient(new Minus());
            Console.WriteLine("Minus: " + minusClient.Calculate(7, 1).ToString());

            CalculateClient plusClient = new CalculateClient(new Plus());
            Console.WriteLine("Plus: " + plusClient.Calculate(7, 1).ToString());

            CalculateClient divClient = new CalculateClient(new Div());
            Console.WriteLine("Div: " + plusClient.Calculate(10, 5).ToString());

        }
    }
}
