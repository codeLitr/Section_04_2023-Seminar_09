// Обсуждение домашнего задания к Семинару №8:

// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей
// суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер
// строки с наименьшей суммой элементов: 1 строка

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

void Sum(int[,] array, int[] arr)
{
    int i = 0;
    int sum = 0;
    for (; i < array.GetLength(0);)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
            if (j == array.GetLength(1) - 1)
            {
                arr[i] = sum;
                System.Console.Write(arr[i] + " ");
                sum = 0;
                i++;
            }
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void FindStringWithMinSum(int[] arr)
{
    int i = 0;
    int index = 0;
    int min = arr[i];
    for (; i < arr.Length; i++)
    {
        if (min >= arr[i])
        {
            min = arr[i];
            index = i + 1;
        }
    }
    System.Console.WriteLine($"{index} строка");
}


int lines = 4;
int columns = 4;
int[,] array = new int[lines, columns];
FillArrayRandomNumbers(array);
PrintArray(array);
int[] arr = new int[lines];
Sum(array, arr);
FindStringWithMinSum(arr);
