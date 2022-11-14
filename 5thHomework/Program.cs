// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void Zadacha10()
    {
        Console.WriteLine("Enter 3 digits number");
        int number = Convert.ToInt32 (Console.ReadLine());
        int hundreds = number % 100;
        int result = hundreds / 10;
        
        {   
            if (number >= 100 & number <= 999)
                {   
                    Console.WriteLine(  " This is 2nd number " + result);
                }
            
            else
            {
             Console.WriteLine("You didnt entered 3 digits number, try again!");
            }
        }   
    }
Zadacha10();