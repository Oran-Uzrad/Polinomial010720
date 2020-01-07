using System;

namespace Polinomial010720
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cArr = new int[10];
            int l = ReadCoefficients(cArr);
            int x = ReadInt("Enter X: ");
            int poli = 0;
            for (int i = 0; i < l; i++)
            {
                poli = poli + cArr[i] * MyPow(x, i);
            }
            Console.WriteLine("Result: {0}", poli);
        }

        public static int MyPow(int a, int b)
        {
            int result = 1;

            for (int i = 1; i <= b; i++ )
            {
                result = result * a;
            }

            return result;
        }

        public static int ReadCoefficients(int[] cofArr)
        {
            string inputString = "";
            int index = 0;
            while (!(inputString == "quit") && (index < cofArr.Length))
            {
                Console.Write("Enter c{0} or quit: ", index);
                inputString = Console.ReadLine();
                if (!(inputString == "quit"))
                {
                    cofArr[index] = int.Parse(inputString);
                    index++;
                }
            }
            return index;
        }

        public static int ReadInt(string whatToPrint)
        {
            Console.Write(whatToPrint);
            return int.Parse(Console.ReadLine());
        }
    }
}
