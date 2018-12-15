using System;
using System.Collections.Generic;
using System.Text;
namespace Calculator
{
    class Add
    {
        public void Plus(Double Count, Double Count1)
        {
            Console.WriteLine("{0}+{1}={2}", Count, Count1, Count + Count1);

        }
    }
    class Minus
    {
        public void Minu(Double Count, Double Count1)
        {
            Console.WriteLine("{0}-{1}={2}", Count, Count1, Count - Count1);

        }
    }
    class Multiply
    {
        public void Mul(Double Count, Double Count1)
        {
            Console.WriteLine("{0}*{1}={2}", Count, Count1, Count * Count1);

        }
    }
    class Divide
    {
        public void Div(Double Count, Double Count1)
        {
            Console.WriteLine("{0}/{1}={2}", Count, Count1, Count / Count1);

        }
    }
}