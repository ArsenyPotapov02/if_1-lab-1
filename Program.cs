using System;

namespace ConsoleApp1

{
    public class Logic
    {
        public struct Result
        {
            public int min;
            public int max;
            public int med;
        }

        public static Result FindAll(int x, int y, int z)
        {
            
            int _min = Logic.GetMin(x, y, z);
            int _max = Logic.GetMax(x, y, z);
            int _med = Logic.GetMed(x, y, z);
            return new Result
            {
                min = _min,
                max = _max,
                med = _med,
            };
        }



        public static int GetMax(int x, int y, int z)
        {
            int max = 0;

            if (x >= y && x >= z)
                max = x;
            else if (y >= x && y >= z)
                max = y;
            else if (z >= x && z >= y)
                max = z;

            return max;
        }
        public static int GetMin(int x, int y, int z)
        {
            int min = 0;

            if (x <= y && x <= z)
                min = x;
            else if (y <= x && y <= z)
                min = y;
            else if (z <= x && z <= y)
                min = z;

            return min;
        }
        public static int GetMed(int x, int y, int z)
        {
            int med = 0;
            int max = Logic.GetMax(x, y, z);
            int min = Logic.GetMin(x, y, z);

            if (y != max && y != min)
                med = y;
            if (x != max && x != min)
                med = x;
            if (z != max && z != min)
                med = z;

            return med;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("введите 3 числа:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            int max = Logic.GetMax(x, y, z);
            int min = Logic.GetMin(x, y, z);
            int med = Logic.GetMed(x, y, z);

            Console.WriteLine("Максимальное число {0}  Минимальное число {1} Среднее число {2}", max, min, med);
            Console.ReadLine();



        }
    }
}

