

internal class Program
{
    private static void Main(string[] args)
    {
        //Задача 47. Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
        // m = 3, n = 4.
        // 0,5 7 -2 -0,2
        // 1 -3,3 8 -9,9
        // 8 7,8 -7,1 9
        void Zadacha47()
        {
            int rows = 4;
            int columns = 3;
            double[,] numbers = new double[rows, columns];
            FillArrayDouble(numbers);
            PrintArrayDouble(numbers);
        }

        void Zadacha50()
        {
            //Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

            int rows = 4;
            int columns = 4;
            int[,] array = new int[rows, columns];

            FillArray(array, 0, 10);
            PrintArray(array);
            Console.WriteLine("Введите первый индекс элемента: A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второй индекс элемента: B");
            int B = Convert.ToInt32(Console.ReadLine());

            if (A >= rows | B >= columns)
            {
                Console.WriteLine("Таких индексов в этом массиве не существует!");
                return;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    if (i == B && j == A)
                    {
                        Console.WriteLine($"Значение элемента введенными вами индексов [{A},{B}] = {array[i, j]}");
                        return;
                    }
                }
            }
        }

        void Zadacha52()
        {
            //Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
            int rows = 4;
            int columns = 4;
            int[,] array = new int[rows, columns];
            double[] sum = new double[rows];

            FillArray(array, 0, 10);
            PrintArray(array);

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    sum[j] += array[i, j];
                }
            }
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{(sum[j] / columns),1} ");
            }
        }

        //8 Урок. Домашнее задание!
        void Zadacha54()
        {
            //Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
            int rows = 4;
            int columns = 4;
            int[,] numbers = new int[rows, columns];


            FillArray(numbers, 10, 100);
            Console.WriteLine();
            PrintArray(numbers);

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1) - 1; j++)
                {
                    for (int k = 0; k < numbers.GetLength(1) - 1; k++)
                    {
                        if (numbers[i, k] < numbers[i, k + 1])
                        {
                            int temp = 0;
                            temp = numbers[i, k];
                            numbers[i, k] = numbers[i, k + 1];
                            numbers[i, k + 1] = temp;
                        }
                    }
                }
            }
            Console.WriteLine();
            PrintArray(numbers);
        }
        Zadacha54();


    }







    //Вспомогательные методы
    static void FillArray(int[,] numbers, int minValue, int maxValue)
    {
        //Заполнение Двумерного массива
        maxValue++;
        Random rand = new Random();
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                numbers[i, j] = rand.Next(minValue, maxValue);

            }

        }
    }
    static void PrintArray(int[,] numbers)
    //Двумерный массивб вывод
    {
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{numbers[i, j]}\t");

            }
            Console.WriteLine();

        }
    }

    static void PrintArray1(int[] numbers)
    //печать одномерного массива
    {
        int lenght = numbers.Length;
        Console.WriteLine("Текущий массив: ");

        for (int i = 0; i < lenght; i++)
        {
            Console.Write(numbers[i] + " ");
        }

        Console.WriteLine("\n");
    }

    static void FillArrayDouble(double[,] numbers)
    {
        //Заполнение Двумерного массива случайными вещественными числами;

        Random rand = new Random();
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                numbers[i, j] = Math.Round(rand.NextDouble() * 100 - 33.2, 1);

            }
        }
    }
    static void PrintArrayDouble(double[,] numbers)
    //Двумерный массивб вывод
    {
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{numbers[i, j]}\t");

            }
            Console.WriteLine();
        }
    }

}