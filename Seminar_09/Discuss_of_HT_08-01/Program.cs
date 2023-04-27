// Обсуждение домашнего задания к Семинару №8:

// Задача 54: 
// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// МОЙ ВАРИАНТ:

// void FillArray2D(int[,] array2D)
// {
//     Random random = new Random();
//     for (int i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//             array2D[i, j] = random.Next(1, 10);
//         }
//     }
// }

// void PrintArray2D(int[,] array2D)
// {
//     for (int i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//             System.Console.Write(array2D[i, j] + " ");
//         }

//         System.Console.WriteLine();
//     }
// }

// void SortDescendOrderInArray2D(int[,] array2D)
// {
//     for (int i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//             for (int k = 0; k < array2D.GetLength(1) - 1; k++)
//             {
//                 if (array2D[i, k] < array2D[i, k + 1])
//                 {
//                     int temp = array2D[i, k + 1];
//                     array2D[i, k + 1] = array2D[i, k];
//                     array2D[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// int rows = 3;
// int columns = 4;

// int[,] array2D = new int[rows, columns];

// FillArray2D(array2D);
// PrintArray2D(array2D);
// System.Console.WriteLine();

// SortDescendOrderInArray2D(array2D);
// PrintArray2D(array2D);


// ВАРИАНТ ПРЕПОДАВАТЕЛЯ:

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

void BubbleSor2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        BubbleSort(array, i);
    }
}

void BubbleSort(int[,] array, int indexRow)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            if (array[indexRow, i] < array[indexRow, j])
            {
                Swap(ref array[indexRow, i], ref array[indexRow, j]);
            }
        }
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int lines = 3;
int columns = 4;
int[,] array = new int[lines, columns];
FillArrayRandomNumbers(array);
PrintArray(array);
BubbleSor2DArray(array);
PrintArray(array);