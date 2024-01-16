// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
int[] CreateArray (int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i< array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int GetCountOfInterestingNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i< arr.Length; i++)
    {
        if (arr[i] %2==0)
        {
            count++;
        }
    }
    return count;   
}

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] res = CreateArray(N, 100, 999);
Console.WriteLine($"Массив: [{string.Join("; ", res)} ]");
Console.WriteLine($"Четных чисел в массиве: {GetCountOfInterestingNumbers(res)}");

// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
