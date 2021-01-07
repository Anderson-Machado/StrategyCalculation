using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyCalculation
{
    public class Div : ICalculateInterface
    {
        public int Calculate(int value1, int value2)
        {
            return value1 / value2;
        }
    }
}
