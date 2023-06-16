//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

Console.Write("Введите колличество строк в двумерном массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов в двумерном массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[m, n];

void GenerateRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("");
    }
}

GenerateRandomArray(numbers);
Console.WriteLine("Исходный массив: ");
PrintRandomArray(numbers);

void ArraySort(int[,] array)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < numbers.GetLength(1) - 1; z++)
            {
                if (numbers[i, z] < numbers[i, z + 1])
                {
                    int temp = 0;
                    temp = numbers[i, z];
                    numbers[i, z] = numbers[i, z + 1];
                    numbers[i, z + 1] = temp;
                }
            }
        }
    }
}

ArraySort(numbers);
Console.WriteLine("Массив после сортировки: ");
PrintRandomArray(numbers);