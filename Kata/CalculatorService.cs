using System;
using System.Collections.Generic;
using System.Text;

namespace Kata
{
    public class CalculatorService : ICalculatorService
    {
        public int add(int i, int j)
        {
            return i + j;
        }
    }
}
