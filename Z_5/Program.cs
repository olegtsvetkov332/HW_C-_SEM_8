//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

int[,] matrix = new int[4, 4];
int num = 1;
void SpiralMatrix(int[,] array, int arg)
{
    int i = 0;
    int j = 0;
    while (arg <= 16)
    {
        array[i, j] = arg;
        if (i <= j + 1 && i + j < 3)
            ++j;
        else if (i < j && i + j >= 3)
            ++i;
        else if (i >= j && i + j > 3)
            --j;
        else
            --i;
        arg++;
    }
}

void PrintResultArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j].ToString("D2")} ");
        }
        Console.WriteLine("");
    }
}

SpiralMatrix(matrix, num);
PrintResultArray(matrix);