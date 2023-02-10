// Задача 29: Напишите программу, 
//которая задаёт массив из 8
//элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int n = 8;
int[] nums = new int[n];
int i = 0;
EnteringAnElement(nums);
PrintArray(nums);


void EnteringAnElement(int[] nums)
{
    while (i < n)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        nums[i] = int.Parse(Console.ReadLine());
        Console.WriteLine();
        i++;
    }
}


void PrintArray(int[] nums)
{
    Console.Write("[ ");
    for (int i = 0; i < nums.Length; i++)
    {
        Console.Write(nums[i] + ", ");
    }
    Console.Write("]");
}


