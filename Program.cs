//Дан двумерный массив.

//732

//496

//185

//Отсортировать данные в нем по возрастанию.

//123

//456

//789

//Вывести результат на печать.

//class Program

//{

//    static void Main(string[] args)

//    {

//        int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

//    }

//}
using System;

namespace lesson2
{
    internal class Program
    {
        public static int[,] GenerateArray(int i, int j)
        {
            if (i == 0 || j == 0)
            {
                int[,] table = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
                return table;
            }
            else
            {
                int[,] table = new int[i, j];
                Random random = new Random();
                for (int a = 0; a < i; a++)
                {
                    for (int b = 0; b < j; b++)
                    {
                        table[a, b] = random.Next(0, 9);
                    }
                }
                return table;
            }         
        }

        public static void PrintArray(int[,] array)
        {
            for (int a = 0; a < array.GetLength(0); a++)
            {
                for (int b = 0; b < array.GetLength(1); b++)
                {
                    Console.Write(array[a, b] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void SortArray(int[,] array)
        {
            int[] arraysort = new int[array.GetLength(0) * array.GetLength(1)];
            for (int i = 0,f = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++, f++)
                {
                    arraysort[f] = array[i, j];
                }
            }
            Array.Sort(arraysort);
            for (int f = 0; f < arraysort.Length; f++)
            {
                array[f / array.GetLength(1), f % array.GetLength(1)] = arraysort[f];
            }
        }

        private static void Main(string[] args)
        {

            int i = 0;
            int j = 0;

            if (args.Length == 2)
            {
                bool error = false;
                if (int.TryParse(args[0], out i) == false)
                {
                    Console.WriteLine("Неверно указана размерность превого уровня");
                    error = true;
                }
                if (int.TryParse(args[1], out j) == false)
                {
                    Console.WriteLine("Неверно указана размерность второго уровня");
                    error = true;
                }
                if (error)
                {
                    return;
                }
                
            }

            int[,] array = GenerateArray(i, j);
            Console.WriteLine("Искомый массив: ");
            PrintArray(array);
            SortArray(array);
            Console.WriteLine("Сортированный массив: ");
            PrintArray(array);
        }
    }
} 