// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Input your number");

int a  = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0) 
{
Console.WriteLine("Your number is even.");
}
else
{
   Console.WriteLine("Your number is not even."); 
}