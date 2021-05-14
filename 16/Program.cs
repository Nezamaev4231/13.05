using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            //16
            Console.WriteLine("Введите число A1");
            double A1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число A2");
            double A2 = Convert.ToDouble(Console.ReadLine());
            double P = A1 + A2;
            Console.WriteLine(P);
            Console.ReadKey();
        }
    }
}
