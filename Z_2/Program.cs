//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] numbers = new int[4, 4];

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

void SumSortArray(int[,] array) //Считает сумму элементов в каждой строке и выводит номер строки с нименьшей суммой элементов
{
    int[] mini = new int[0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp+= array[i, j];
        }
        mini= mini.Append(temp).ToArray();
    }
    int min = mini[0];
    int index = 0;
    for (int i = 0; i < 4; i++)
    {
        if (min > mini[i])
        {
            min = mini[i];
            index = i;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {index+1} строка");
}

GenerateRandomArray(numbers);
PrintRandomArray(numbers);
SumSortArray(numbers);