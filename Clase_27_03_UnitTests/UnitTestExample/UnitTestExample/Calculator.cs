using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample
{
    public class Calculator
    {
        public int add(int a, int b)
        {
            int result = a + b;

            return result;
        }

        public int multiply(int a, int b)
        {
            int result = a * b;

            return result;
        }
    }
}
