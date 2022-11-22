using System.Threading.Tasks.Dataflow;
using System.Globalization;
void Zadacha24()
{
    //Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
    Random rand = new Random();
    int number = rand.Next(1, 16);
    Console.WriteLine("Введено число: " + number);

    //1 2 3 4 5 ...
    int counter = 1;
    int sum = 0;
    while (counter <= number)
    {
        Console.WriteLine($"{sum} + {counter} = ");
        sum = sum + counter;
        Console.WriteLine(sum);
        counter++;
    }
    Console.WriteLine("Ответ: " + sum);

    sum = 0;
    while (number > 0)
    {
        sum += number;
        number--;
    }
    Console.WriteLine("Ответ: " + sum);
}

void Zadacha26()
{
    //Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
    Random rand = new Random();
    int number = rand.Next(1, 1000000);
    Console.WriteLine("Введено число: " + number);
    int result = 0;
    while (number >= 1)
    {
        number = number / 10;
        result += 1;
    }
    Console.WriteLine($"В числе {result} цифр(ы)");
}

void Zadacha28()
{
    //Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
    Random rand = new Random();
    int number = rand.Next(1, 16);
    Console.WriteLine("Введено число: " + number);
    int counter = 1;
    int sum = 1;

    while (counter <= number)
    {
        Console.Write($"{sum} * {counter} = ");
        sum = sum * counter;
        Console.WriteLine(sum);
        counter++;
    }
    Console.WriteLine("Ответ: " + sum);

    sum = 1;

    while (number > 0)
    {
        sum *= number;
        number--;
    }
    Console.WriteLine("Ответ: " + sum);

}
void FillArray()
{

}
void Zadacha30()
{
    //Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
    int size = 8;
    int[] numbers = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        numbers[i] = rand.Next(0, 2);
    }
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine(numbers[i]);
    }
    Console.WriteLine(numbers);
}

//Домашка
void Zadacha19()
{
    //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    Console.WriteLine("введите пятизначное число");
    int number = int.Parse(Console.ReadLine());
    int palindr = 0, num = number;
    while (number > 0)
    {
        palindr = palindr * 10 + number % 10; number /= 10;
    }
    Console.WriteLine(num == palindr ? "палиндром" : "не палиндром");


}
void Zadacha23()
{
    //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    Console.WriteLine("введите число");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= n; j++)
        {
            for (int e = 1; e <= n; e++)
            {
                if (i == j & j == e)
                {
                    Console.WriteLine($"{i} x {j} x {e}  = {i * j * e}");
                }
            }
        }
    }
}
void Zadacha21()
{
    //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    Console.Write("Введите AX1: ");
    double X1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите AY1: ");
    double Y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите AZ1: ");
    double Z1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите BX2: ");
    double X2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите BY2: ");
    double Y2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите BZ2: ");
    double Z2 = Convert.ToDouble(Console.ReadLine());

    double distance = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z1 - Z2, 2));

    Console.WriteLine("Расстояние между точками в 3D пространстве  = {0}", Math.Round(distance, 2));

}

void Zadacha25()
{
    //Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
    //число, которое нужно возвести в степень
    Console.Write("Введите число   : ");
    int num = int.Parse(Console.ReadLine());
    //степень числа
    Console.Write("Введите степень : ");
    int n = int.Parse(Console.ReadLine());
    //число, возведенное в степень
    int num_n = 1;
    for (int i = 0; i < n; i++)
    {
        num_n *= num;
    }
    Console.WriteLine("{0} ^ {1} = {2}", num, n, num_n);
    Console.ReadKey();
    

}


Zadacha25();