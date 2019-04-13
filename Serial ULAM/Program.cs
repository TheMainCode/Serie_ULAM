using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serial_ULAM
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Teclea un numero");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 1)
            {
                if (num == 0)
                    Console.WriteLine("Invalido");
                else if (Math.Pow(-1, num) > 0)
                {
                    num = num / 2;
                    Console.WriteLine(num + ",");
                }

                else
                {
                    num = (num * 3) + 1;
                Console.WriteLine(num +",");
            }

            }

            Console.ReadKey();
        }
    }
}
