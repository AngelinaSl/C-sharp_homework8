/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

void FillArray(int[] myArray)
{
    int length = myArray.Length;
    int index = 0;
    int number = 1;
    while (index < length)
    {
        myArray[index] = number;
        index++;
        number++;
    }
}

int FillArrayRight(int[,] array, int i, int k, int[] numbersArray)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == 0)
        {
            array[i, j] = numbersArray[k];
            k++;
        }
    }
    return k;
}

int FillArrayDown(int[,] array, int j, int k, int[] numbersArray)
{
    for (int i = 1; i < array.GetLength(0); i++)
    {
        if (array[i, j] == 0)
        {
            array[i, j] = numbersArray[k];
            k++;
        }
    }
    return k;
}

int FillArrayLeft(int[,] array, int i, int k, int[] numbersArray)
{
    for (int j = array.GetLength(1) - 2; j >= 0; j--)
    {
        if (array[i, j] == 0)
        {
            array[i, j] = numbersArray[k];
            k++;
        }
    }
    return k;
}

int FillArrayUp(int[,] array, int j, int k, int[] numbersArray)
{
    for (int i = array.GetLength(0) - 2; i > 0; i--)
    {
        if (array[i, j] == 0)
        {
            array[i, j] = numbersArray[k];
            k++;
        }
    }
    return k;
}


void FillArraySpiral(int[,] array, int[] numbersArray, int size)
{
    int number = 0;
    int count = 1;
    int i = 0;
    int j = 0;
    int k = 0;
    while (numbersArray[k] <= size * size)
    {
        if (array[i, j] == 0)
        {
            i = number;
            k = FillArrayRight(array, i, k, numbersArray);

            j = array.GetLength(1) - count;
            k = FillArrayDown(array, j, k, numbersArray);

            i = array.GetLength(0) - count;
            k = FillArrayLeft(array, i, k, numbersArray);

            j = number;
            k = FillArrayUp(array, j, k, numbersArray);
        }
        number++;
        count++;
        i = number;
        j = number;
    }
}

void PrintNewArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] >= 10)
            {
                Console.Write($"{array[i, j]}  ");
            }
            else
            {
                Console.Write($"0{array[i, j]}  ");
            }        
        } 
        Console.WriteLine();
    }
}

    int[] numbersArray = new int[100];
    FillArray(numbersArray);
    int size = 4;
    int[,] myArray = new int[size, size];
    FillArraySpiral(myArray, numbersArray, size);
    PrintNewArray(myArray);

