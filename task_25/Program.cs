// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16





void Degree(int a, int b)
{
    int resalt = a;
    int i = 1;
    while (i < b)
    {
        resalt = a * resalt;
        i++;
    }
    Console.WriteLine(resalt);
}


Console.Clear();
Console.Write("Ввидите числитеть: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввидите множитель: ");
int b = Convert.ToInt32(Console.ReadLine());
int resalt = a;
Degree(a, b);
