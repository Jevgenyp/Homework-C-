

using System.Dynamic;
using System.Net.NetworkInformation;
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
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второй индекс элемента: B");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a >= rows | b >= columns)
            {
                Console.WriteLine("Таких индексов в этом массиве не существует!");
                return;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    if (i == a && j == b)
                    {
                        Console.WriteLine($"Значение элемента введенными вами индексов [{a},{b}] = {array[i, j]}");
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
            double[] sum = new double[columns];

            FillArray(array, 0, 10);
            PrintArray(array);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sum[j] += array[i, j];
                }
            }
            for (int j = 0; j < rows; j++)
            {
                Console.Write($"{(sum[j] / rows),1}\t");
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
                Console.WriteLine();
                PrintArray(numbers);
            }
        }


        void Zadacha56()
        {
            //Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
            int rows = 4;
            int columns = 6;
            int[,] numbers = new int[rows, columns];

            FillArray(numbers, -10, 100);
            Console.WriteLine();
            PrintArray(numbers);

            int sum = 0;
            int tempSum = 0;

            int numberOfRow = -1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    tempSum += numbers[i, j];
                }
                if (tempSum < sum | sum == 0) { sum = tempSum; numberOfRow = i; }
                tempSum = 0;
            }

            Console.WriteLine($"Строка с наименьшей суммой элемнтов: {numberOfRow}, сумма элементов равна {sum}");

        }
        void Zadacha58()
        //Задача 58. Заполните спирально массив 4 на 4 числами от 1 до 16.
        {
            int rows = 4;
            int columns = 4;
            int[,] array = new int[rows, columns];
            FillArraySpiral(array);
            PrintArray(array);
        }

        Zadacha58();

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

    static void FillArraySpiral(int[,] spiralArray)
    //Заполните спирально массив
{

    int num = 1;
    int i = 0;
    int j = 0;

    for (j = 0; j < spiralArray.GetLength(1); j++)
    {
        spiralArray[i, j] = num++;
    }

    for (i = i + 1; i < spiralArray.GetLength(0); i++)
    {
        spiralArray[i, j - 1] = num;
        num++;
    }

    for (j = j - 2; j >= 0; j--)
    {
        spiralArray[i - 1, j] = num;
        num++;
    }

    for (i = i - 2; i > 0; i--)
    {
        spiralArray[i, j + 1] = num;
        num++;
    }

    for (j = 1; j < spiralArray.GetLength(0) - 1; j++)
    {
        spiralArray[i + 1, j] = num;
        num++;
    }

    for (j = j - 1; j > 0; j--)
    {
        spiralArray[i + 2, j] = num;
        num++;
    }


}

}
