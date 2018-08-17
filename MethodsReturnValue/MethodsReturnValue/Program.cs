using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsReturnValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(25, 25));
            Console.WriteLine(TellName("Lucas Medina"));
            Console.WriteLine(Divide(13, 10));
            Console.Read();
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static string TellName(string name)
        {
            return "Your name is " + name;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
