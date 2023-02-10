// Задача 27: Напишите программу, 
//которая принимает на вход число
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число:  ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(num);
int sum = 0;

while (num > 0)
{
int x = num % 10;
num = num / 10;
sum = sum + x;
}
Console.Write($" -> " + sum);