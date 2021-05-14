using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._05
{
    class Program
    {
        static void Main(string[] args)
        {
            //9
            Console.WriteLine("Введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число R1");
            double R1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число R2");
            double R2 = Convert.ToDouble(Console.ReadLine());
            double S = R1 * R2;
            Console.WriteLine(S);
            Console.ReadKey();
        }
    }
}
