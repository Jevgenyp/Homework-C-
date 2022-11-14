// Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter your number");

        int n = Convert.ToInt32(Console.ReadLine());
        int i = 2;
        
        {
            Console.WriteLine("These are yours even numbers!");
            while (i <= n )
            {

                Console.WriteLine(i);
                i = i + 2;
                
            }
            
         
        }
    }
}