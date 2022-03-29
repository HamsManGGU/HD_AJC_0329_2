using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0329_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. while만  이용하여 2단 4단 6단 구구단을 출력하는 프로그램을 작성하세요.

            int i = 2;

            while (i < 7)
            {
                int j = 1;
                while (j < 10)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                    j++;
                }
                Console.WriteLine("\n");
                i += 2;
            }
        }
    }
}
