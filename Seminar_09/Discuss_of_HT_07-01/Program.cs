// Обсуждение домашнего задания к Семинару №7:

// Задача 47: 
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// МОЙ ВАРИАНТ:

// void FillArray2D(double[,] array2D)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//             array2D[i, j] = Math.Round(rnd.Next(-100, 100) + rnd.NextDouble(), 2);
//         }
//     }
// }

// void PrintArray2D(double[,] array2D)
// {
//     for (int i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//             System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//             System.Console.Write(array2D[i, j] + " | ");
//         }

//         System.Console.WriteLine();
//     }
// }

// int m = 3;
// int n = 4;
// double[,] array2D = new double[m, n];

// FillArray2D(array2D);
// PrintArray2D(array2D);



// ВАРИАНТ ПРЕПОДАВАТЕЛЯ:

void FillArray2D(double[,] array2D)
{
    Random rnd = new Random();

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = rnd.NextDouble() * 100;
        }
    }
}

void PrintArray2D(double[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write(Math.Round(array2D[i, j], 2) + " ");
        }
        System.Console.WriteLine();
    }
}

double[,] array2D = new double[3, 4];
FillArray2D(array2D);
PrintArray2D(array2D);