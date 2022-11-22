
internal class Program
{
    private static void Main(string[] args)
    {
        void Zadacha17()
        {
            //Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка
            Random rand = new Random();
            // Тип_данных имя_переменных = new тип_данных();
            int x = rand.Next(-10, 11);
            int y = rand.Next(-10, 11);
            Console.WriteLine($"A({x}, {y})");
            if (x > 0 && y > 0)
            {
                Console.WriteLine("1я четверть");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("2я четверть");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("3я четверть");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("4я четверть");
            }
            else
            {
                Console.WriteLine("Точка лежит на координатной прямой");
            }
        }

        void Zadacha18()
        {

        }



        // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
        //int x = 5;
        //Math.Pow(x, 2);
        //Math.Sqrt(x);
        //Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))
        double Gipotenuza(int x1, int y1, int x2, int y2)
        {
            var x = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return Math.Round(x, 2);
        }
        void Zadacha21()
        {
            Random rand = new Random();
            int x1 = rand.Next(-10, 11);
            int y1 = rand.Next(-10, 11);
            Console.WriteLine($"x1 = {x1} y1 = {y1}");
            int x2 = rand.Next(-10, 11);
            int y2 = rand.Next(-10, 11);
            Console.WriteLine($"x2 = {x2} y2 = {y2}");
            Console.WriteLine($"Расстояние между точками = {Gipotenuza(x1, y1, x2, y2)}");
        }

        void Zadacha21()
        {

            static void Main(string[] args)
            {
                int x1 = int.Parse(Console.ReadLine());
                int x2 = int.Parse(Console.ReadLine());
                int y1 = int.Parse(Console.ReadLine());
                int y2 = int.Parse(Console.ReadLine());
                Function.Otr(x1, x2, y1, y2);
                Console.ReadLine();
            }
        }
        Zadacha21();
    }
}

class Function
{
    public static void Otr(int x1, int x2, int y1, int y2)
    {
        double c = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine("Отрезок= " + c);
    }
}



