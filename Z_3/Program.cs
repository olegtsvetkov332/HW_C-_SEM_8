//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];
int[,] ResultMatrix = new int[2, 2];
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

GenerateRandomArray(matrix1);
GenerateRandomArray(matrix2);

void PrintRandomArray(int[,] array1, int[,] array2)
{
    for (int row = 0; row < array1.GetLength(0); row++)
    {
        for (int col = 0; col < array1.GetLength(1); col++)
            Console.Write(array1[row, col] + " ");
        Console.Write(" | ");
        for (int col = 0; col < array2.GetLength(1); col++)
            Console.Write(array2[row, col] + " ");
        Console.WriteLine();
    }
}

PrintRandomArray(matrix1, matrix2);

void MultiplyMatrix(int[,] m1, int[,] m2, int[,] RM)
{
    for (int i = 0; i < RM.GetLength(0); i++)
    {
        for (int j = 0; j < RM.GetLength(1); j++)
        {
            int result = 0;
            for (int k = 0; k < RM.GetLength(1); k++)
            {
                result += m1[i, k] * m2[k, j];
            }
            RM[i, j] = result;
        }
    }
}

void PrintResultArray(int[,] array)
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

MultiplyMatrix(matrix1, matrix2, ResultMatrix);
Console.WriteLine("Произведение двух матриц: ");
PrintResultArray(ResultMatrix);