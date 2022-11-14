Console.WriteLine("Enter 1st number");

int a  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 2nd number");

int b  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 3d number");

int c = Convert.ToInt32(Console.ReadLine());

int Max(int a, int b, int c)
{
    int result = a;
    if (b>result) result = b;
    if (c>result) result = c;
    return result;
}
int max = Max(a, b, c);
Console.WriteLine("The max number is");
Console.WriteLine(max);