using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProGitForProgrammers
{
    class ProGitForProgrammers
    {
        static async Task Main(string[] args)
        {
            int num1, num2, num3, num4;
            Console.WriteLine("Enter two numbers to add");
            Console.WriteLine("Also, enter two number to divide");
            Console.WriteLine("Enter first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fourth number");
            num4 = int.Parse(Console.ReadLine());
            await callMethod(num1, num2, num3, num4);
            Console.ReadKey();
        }

        public static async Task callMethod(int num1, int num2, int num3, int num4)
        {
            int addTotal, divideTotal;
            addTotal = await addMethod(num1, num2);
            divideTotal = await divideMethod(num3, num4);
            Console.WriteLine(num1 + " + " + num2 + " = " + addTotal + "\n" + num3 + " / " + num4 + " = " + divideTotal);
        }

        public static async Task<int> addMethod(int num1, int num2)
        {
            await Task.Run(() =>
            {
                num1 += num2;
            });
            return num1;
        }

        public static async Task<int> divideMethod(int num3, int num4)
        {
            await Task.Run(() =>
            {
                num3 /= num4;
            });
            return num3;
        }
    }
}