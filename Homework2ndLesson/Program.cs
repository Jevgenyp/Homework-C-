internal class NewBaseType
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
        void Zadacha10()
        {
            Console.WriteLine("Enter 3 digits number");
            int number = Convert.ToInt32(Console.ReadLine());
            int hundreds = number % 100;
            int result = hundreds / 10;

            {
                if (number >= 100 & number <= 999)
                {
                    Console.WriteLine(" This is 2nd diggit of your number - " + result);
                }

                else
                {
                    Console.WriteLine("You didnt entered 3 digits number, try again!");
                }
            }
        }

        //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        void Zadacha13()
        {
            Console.WriteLine("Enter your number");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 0;

            if (number < 100)

            {
                Console.WriteLine("there is no 3d diggit");
            }
            else if (number < 1000)
            {
                number = number % 10;
                Console.WriteLine("Here is your 3d diggit " + number);
            }
                 else
            {
                while (number > 1000)
                    {
                    i = number % 10;
                number = number / 10;
                    }
                if (number < 1000)
                    {
                    number = number % 10;
                Console.WriteLine("Here is your 3d diggit " + number);
                    }
            }
        }
       Zadacha13();
        

        /*Dopolniteljnoe reshenie!!!
        Console.Write("Enter your number: ");
        int anyNumber = Convert.ToInt32(Console.ReadLine());
        string anyNumberText = Convert.ToString(anyNumber);
        if (anyNumberText.Length > 2){
          Console.WriteLine("3d digit of your number -> " + anyNumberText[2]);
        }
        else {
          Console.WriteLine("-> there is no 3d digit");
        }*/

       //Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
        void Zadacha15()
        {
        
            Console.WriteLine("Enter number day of the week");
            int number = Convert.ToInt32(Console.ReadLine());
            int monday = 1;
            int tuesday = 2;
            int wednsday = 3;
            int thursday = 4;
            int friday = 5;
            int saturday = 6;
            int sunday = 7;
            
            if(number==6)
            {
                Console.WriteLine("you can stay home, its saturday!");
            }
            else if(number == 7)
            {
                Console.WriteLine("you can stay home, its sunday!");
            }
            
            else if(number> 0 && number <= 5)
            {
                Console.WriteLine("Its work day, today you need to go on work!");
            }
            else
            {
                Console.WriteLine("You entered incorrect number, please try again!");
                Zadacha15();
            }
        } 
        
    }
    
} 

