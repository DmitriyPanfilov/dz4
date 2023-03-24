// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



void Sum(int numbers)
{
    int y = 0;
    while(numbers > 0)
    {
       
        y += numbers % 10;
        numbers = numbers / 10; 
        
    }
    
    System.Console.WriteLine(y);
}


Console.WriteLine("enter a number ");
int numbers = Convert.ToInt32(Console.ReadLine());
Sum(numbers);
