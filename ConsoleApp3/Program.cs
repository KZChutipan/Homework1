using System;
using Calculator;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "\nWelcome to Program Calculator Number\n" +
                "this program work with 3 or 4 Arguments.\n" +
                "###################################################################\n" +
                "Argument 1 = Mode(1.Add 2.Minus 3.Multiply 4.Divide)\n" +
                "Argument 2 = Count Number\n" +
                "Argument 3 = Count Number1\n" +
                "###################################################################\n";

            if (args.Length != 3)
            {
                Console.WriteLine("{0}", menu);
            }
            else
            {
                if (Convert.ToInt32(args[0]) == 1)
                {
                    Add CountNB = new Add();
                    CountNB.Plus(Convert.ToDouble(args[1]), Convert.ToDouble(args[2]));
                }
                else if (Convert.ToInt32(args[0]) == 2)
                {
                    Minus CountNB = new Minus();
                    CountNB.Minu(Convert.ToDouble(args[1]), Convert.ToDouble(args[2]));
                }
                else if (Convert.ToInt32(args[0]) == 3)
                {
                    Multiply CountNB = new Multiply();
                    CountNB.Mul(Convert.ToDouble(args[1]), Convert.ToDouble(args[2]));
                }
                else
                {
                    Divide CountNB = new Divide();
                    CountNB.Div(Convert.ToDouble(args[1]), Convert.ToDouble(args[2]));
                }
            }
            Console.ReadKey();
        }
    }
}
