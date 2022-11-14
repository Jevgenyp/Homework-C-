Console.WriteLine("Enter 1st number");
int numberone  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2nd number");
int numbertwo  = Convert.ToInt32(Console.ReadLine());
if (numberone > numbertwo)
{
    Console.WriteLine("1st number bigger than 2nd number");
}
else if (numberone < numbertwo)
{
    Console.WriteLine("2nd Number bigger than 1st number");
}
else
{
    Console.WriteLine("1st and 2nd numbers are same");
}
