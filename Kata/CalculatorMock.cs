using System;
using System.Collections.Generic;
using System.Text;

namespace Kata
{
    public class CalculatorMock
    {
        ICalculatorService service = null;
        public CalculatorMock(ICalculatorService service)
        {
            this.service = service;
        }

        public int Perform(int i, int j)
        {
            return service.add(i, j);
        }
    }
}
