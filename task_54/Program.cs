/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] FillAndPrintTwoDimArray(int rowsNumbers, int columnNumbers)
{
    int[,] myArray = new int[rowsNumbers, columnNumbers];
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i, j] = new Random().Next(1, 10);
            Console.Write($"{myArray[i, j]}  ");
        }
        Console.WriteLine();
    }
    return myArray;
}

void RegulateArray(int[,] array)
{
    int help = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    help = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = help;
                }
            }
        }
    }
}

void PrintNewArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int rowsNumbers = new Random().Next(3, 5);
int columnNumbers = new Random().Next(3, 5);
int[,] array = FillAndPrintTwoDimArray(rowsNumbers, columnNumbers);
RegulateArray(array);
Console.WriteLine();
PrintNewArray(array);
