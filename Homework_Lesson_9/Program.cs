
internal class Program
{
    private static void Main(string[] args)
    {
        //Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
        void Zadacha64()
        {
            Console.Clear();
            Console.WriteLine("Введите первое число");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Введите второе число");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Recursion64(m, n);
        }


        void Recursion64(int M, int N)
        {

            if (M > N)
            {
                return;
            }
            if (M % 3 == 0)
            {
                Console.Write($"{M}, ");
            }
            M++;
            Recursion64(M, N);
        }

        void Zadacha66()
        {
            //Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N.

            Console.Clear();
            Console.WriteLine("Введите первое число");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Введите второе число");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Recursion66(m, n);
        }

        void Recursion66(int m, int n, int sum = 0)
        {

            if (m > n)
            {
                Console.WriteLine($"Сумма натуральных элементов в заданном промежутке составляет: {sum}");
                return;
            }
            if (m <= n)
            {
                sum = sum + m;
            }
            m++;
            Recursion66(m, n, sum);
        }

        void Zadacha68()
        {
            //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            Console.WriteLine("Введите M");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите N");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (m < 0 || n < 0)
            {
                Console.WriteLine("Ввведены отрицательные числа");
            }
            else Console.WriteLine($"А({m}, {n}) = {Recursion68(m, n)}");
        }

        int Recursion68(int m, int n)
        {
            if (m == 0) return n + 1;
            else if (m > 0 && n == 0) return Recursion68(m - 1, 1);
            else return (Recursion68(m - 1, Recursion68(m, n - 1)));

        }

    }



}