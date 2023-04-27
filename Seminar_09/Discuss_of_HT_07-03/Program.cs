// Обсуждение домашнего задания к Семинару №7:

// Задача 52:
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// МОЙ ВАРИАНТ:

// int[,] CreateAndFillArray(int rows, int columns, int leftRangeValue, int rightRangeValue)
// {
//     int[,] array2D = new int[rows, columns];

//     Random rnd = new Random();

//     for (int i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//             array2D[i, j] = rnd.Next(leftRangeValue, rightRangeValue);
//         }
//     }
//     return array2D;
// }

// void PrintArray2D(int[,] array2D)
// {
//     for (int i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//             System.Console.Write(array2D[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// void CalculateArithmeticMeanColumns(int[,] array2D)
// {
//     Console.Write("Среднее арифметическое столбца: ");
//     for (int j = 0; j < array2D.GetLength(1); j++)
//     {
//         double sumColumns = 0;
//         double arithmeticMean = 0;

//         for (int i = 0; i < array2D.GetLength(0); i++)
//         {
//             sumColumns += array2D[i, j];
//             arithmeticMean = Math.Round(sumColumns / array2D.GetLength(0), 2);
//         }
//         System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//         System.Console.Write("{0}; ", string.Join("", arithmeticMean));
//     }
// }

// System.Console.WriteLine();
// System.Console.Write("Введите необходимое кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите необходимое кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array2D = CreateAndFillArray(rows, columns, 0, 20);

// System.Console.WriteLine();
// PrintArray2D(array2D);
// System.Console.WriteLine();

// CalculateArithmeticMeanColumns(array2D);



// ВАРИАНТ ПРЕПОДАВАТЕЛЯ:

void FillArray2D(int[,] array2D)
{
    Random rnd = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = rnd.Next(0, 10);
        }
    }
}

void PrintArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write(array2D[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}


double ArithmeticMeanOfColumn(int[,] array2D, int column)
{
    double sum = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        sum += array2D[i, column];
    }
    return sum / array2D.GetLength(0);
}


int line = Convert.ToInt32(Console.ReadLine());
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[line, column];
FillArray2D(matrix);
PrintArray2D(matrix);

for (int i = 0; i < column; i++)
{
    System.Console.WriteLine(ArithmeticMeanOfColumn(matrix, i));
}