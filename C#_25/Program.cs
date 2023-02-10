// Задача 25: Напишите цикл, который 
//принимает на вход два числа (A и B)
// и возводит число A в натуральную 
//степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
// Console.Write("Введите число А: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int numB = Convert.ToInt32(Console.ReadLine());

// int result = 1;
// for (int i = 1; i <= numB; i++)
// {
//     result = result * numA;
// }
// Console.Write($" {numA} ^ {numB} -> " + result);

int numA = ReadInt("Введите число A: ");
int numB = ReadInt("Введите число B: ");
Console.Write($" {numA} ^ {numB} -> " + Math.Pow(numA,numB));

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
