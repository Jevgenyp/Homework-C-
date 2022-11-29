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
    for (int i = 1; i < size; i+=2)
    {
        sum += numbers[i];
    }
     Console.WriteLine("сумма = " + sum);
    

}

Zadacha36();

// Вспомогательные области.

// Работа с Массивами.
void FillArray(int[] numbers, int minValue, int maxValue)
{
    Random rand = new Random();
    int lenght = numbers.Length;

    for (int i = 0; i < lenght; i++)
    {
        numbers[i] = rand.Next(minValue, maxValue);
    }
}
void PrintArray(int[] numbers)
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


