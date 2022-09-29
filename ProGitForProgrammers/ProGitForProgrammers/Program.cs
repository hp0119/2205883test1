using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProGitForProgrammers
{
    class ProGitForProgrammers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there");
            Console.ReadKey();
            int num1, num2, num3;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = Tasks(num1, num2);
            Console.WriteLine(num3);
        }

        public static int Tasks(int num1, int num2)
        {
            int num3 = 0;

            // start tasks
            num3 = num1 + num2;

            return num3;
        }
    }
}