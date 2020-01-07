using System;

namespace MyPow
{
    class Program
    {
        static void Main(string[] args)
        {
            int twoToThePowerOfFive = MyPow(2, 5);
            Console.WriteLine(twoToThePowerOfFive);
        }


        public static int MyPow(int a, int b)
        {
            int result = 1;

            for (int i = 1; i <= b; i++)
            {
                result = result * a;
            }

            return result;
        }
    }
}
