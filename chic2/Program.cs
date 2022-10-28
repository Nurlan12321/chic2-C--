using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chic2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;

            try
            {
                Console.WriteLine("Введите 4 числа");
                A = Convert.ToInt32(Console.ReadLine());
                B = Convert.ToInt32(Console.ReadLine());
                C = Convert.ToInt32(Console.ReadLine());
                D = Convert.ToInt32(Console.ReadLine());
                if (A == B && C == D && A == C && B == D)
                    Console.WriteLine("числа совпадают");
                else
                    Console.WriteLine("числа разные");
                    Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Введите целое число");
                Console.ReadKey();
            }

            
        }
    }
}
