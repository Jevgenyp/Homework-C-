using System.Drawing;
using System.Threading.Tasks.Dataflow;
using System.Globalization;
//Программа
void Zadacha34()
{
    //Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    //[345, 897, 568, 234] -> 2

    int size = 4;
    int[] numbers = new int[size];

    FillArray(numbers, 100, 1000);
    PrintArray(numbers);
    EvenNumber(numbers);
}


void Zadacha36()
{
    //Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
    //[3, 7, 23, 12] -> 19
    //[-4, -6, 89, 6] -> 0

    int size = 4;
    int[] numbers = new int[size];
    int sum = 0;
    FillArray(numbers, -99, 100);
    PrintArray(numbers);
    int lenght = numbers.Length;
    for (int i = 1; i < size; i += 2)
    {
        sum += numbers[i];
    }
    Console.WriteLine("сумма = " + sum);


}

void Zadacha38()
{
    //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    //[3,21 7,04 22,93 -2,71 78,24] -> 80,95
    int size = 4;
    double[] numbers = new double[size];
    FillArrayDouble(numbers);
    ArrayMin(numbers);
    ArrayMax(numbers);
    DifMaxMinArray(numbers);
   // double sum = ArrayMax(numbers) - ArrayMin (numbers);
    //Console.WriteLine($"{ArrayMax} - {ArrayMin} = {sum}");

}
void Zadacha41()
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
{
    Console.WriteLine("Сколько чисел вы хотите ввести?");
    int size = Convert.ToInt32(Console.ReadLine());
    int [] array = new int[size];
    int count = 0;
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите число!");
        int number = Convert.ToInt32(Console.ReadLine());
        number = array[i] + number;
        if(number > 0)
        {
            count = count +1;
        }

    }
    Console.WriteLine($"Пользователь ввел {count} чисел больше нуля.");
}

void Zadacha43()
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
{
    
    Console.WriteLine("Введите точку B1");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите точку K1");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите точку B2");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите точку K2");
    double k2 = Convert.ToInt32(Console.ReadLine());
    double x = (-b2 + b1)/(-k1 + k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Заданные прямые пересекутся в точке A, с координатами X: {x}, Y: {y}");
}
Zadacha43();
// Вспомогательные области.

// Работа с Массивами.
void FillArray(int[] numbers, int minValue, int maxValue)
//массив с целыми числами.
{
    Random rand = new Random();
    int lenght = numbers.Length;

    for (int i = 0; i < lenght; i++)
    {
        numbers[i] = rand.Next(minValue, maxValue);
    }
}
void PrintArray(int[] numbers)
//печать массива
{
    int lenght = numbers.Length;
    Console.WriteLine("Текущий массив: ");

    for (int i = 0; i < lenght; i++)
    {
        Console.Write(numbers[i] + " ");
    }

    Console.WriteLine("\n");
}

void EvenNumber(int[] numbers)
//Вычисления четных чисел массива.
{
    int lenght = numbers.Length;
    int sum = 0;
    for (int i = 0; i < lenght; i++)
    {

        if (numbers[i] % 2 == 0)
        {
            sum = sum + 1;

        }
    }
    Console.WriteLine("В массиве " + sum + " чётных числа!");
    Console.WriteLine("\n");
}

void FillArrayDouble(double[] numbers)
//массив с вещественными числами числами.
{
    Random rand = new Random();
    int lenght = numbers.Length;

    for (int i = 0; i < lenght; i++)
    {
        numbers[i] = Math.Round(rand.NextDouble() * 10, 2);

        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();

}
void ArrayMin(double[] numbers)
{
    //минимальный элемент массива
    int lenght = numbers.Length;
    double minValue = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] < minValue)
        {
            minValue = numbers[i];
        }
    }
    Console.WriteLine("Минимальный Элемент массива: " + minValue);

}

void ArrayMax(double[] numbers)
{
    //максимальный элемент массива
    int lenght = numbers.Length;
    double maxValue = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > maxValue)
        {
            maxValue = numbers[i];
        }
    }
    Console.WriteLine("Максимальный элемент массива: " + maxValue);

}
void DifMaxMinArray(double[] numbers)
{
    //Находим разницу между минимальным элементом и максимальным элементом массива
    //вещественные числа
    int lenght = numbers.Length;
    double maxValue = numbers[0];
    double minValue = numbers[0];
    
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > maxValue)
        {
            maxValue = numbers[i];
        }
    }

    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] < minValue)
        {
            minValue = numbers[i];
        }
       
    }

    double sum = Math.Round((maxValue - minValue),2);
    Console.WriteLine($"Разница между максимальным элементом {maxValue} и минимальным элементом {minValue}  составляет {sum}");
}    



