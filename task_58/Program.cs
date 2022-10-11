/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

void MultiplicationArray(int[,] firstArray, int[,] secondArray)
{
    int[,] arrayMultiplication = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < arrayMultiplication.GetLength(0); i++)
    {
        for (int j = 0; j < arrayMultiplication.GetLength(1); j++)
        {
            int mult = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                mult += firstArray[i, k] * secondArray[k, j];
            }
            arrayMultiplication[i, j] = mult;
            Console.Write($"{arrayMultiplication[i, j]} ");
        }
        Console.WriteLine();
    }
}


int rowsNumbers1 = new Random().Next(3, 5);
int columnNumbers1 = new Random().Next(3, 5);
int rowsNumbers2 = columnNumbers1;
int columnNumbers2 = rowsNumbers1;
int[,] firstArray = FillAndPrintTwoDimArray(rowsNumbers1, columnNumbers1);
Console.WriteLine();
int[,] secondArray = FillAndPrintTwoDimArray(rowsNumbers2, columnNumbers2);
Console.WriteLine();
MultiplicationArray(firstArray, secondArray);
Console.WriteLine();
