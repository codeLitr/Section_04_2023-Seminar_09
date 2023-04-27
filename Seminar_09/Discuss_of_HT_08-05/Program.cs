// Обсуждение домашнего задания к Семинару №8:

// Задача 62:
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//=======================================
// ВАРИАНТ 1 - для массива только 4 на 4:
//=======================================

// void PrintSpiralArray2D(int[,] array2D)
// {
//     for (int i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//             System.Console.Write(array2D[i, j].ToString("D2") + " "); // Добавлен вывод двузначного числа у значений до 10, для соответствия примеру в условиях.       
//         }

//         System.Console.WriteLine();
//     }
// }

// void FillSpiralArray2D(int[,] array2D)
// {
//     int step = 1;
//     for (int i = 0; i < 4; i++)
//     {
//         array2D[0, i] = step++;
//     }
//     for (int i = 1; i < 4; i++)
//     {
//         array2D[i, 3] = step++;
//     }
//     for (int i = 2; i >= 0; i--)
//     {
//         array2D[3, i] = step++;
//     }
//     for (int i = 2; i > 0; i--)
//     {
//         array2D[i, 0] = step++;
//     }
//     for (int i = 1; i <= 2; i++)
//     {
//         array2D[1, i] = step++;
//     }
//     for (int i = 2; i < 3; i++)
//     {
//         array2D[i, 2] = step++;
//     }
//     for (int i = 2; i < 3; i++)
//     {
//         array2D[i, 1] = step++;
//     }
// }

// int sizeArray = 4;
// int[,] array2D = new int[sizeArray, sizeArray];

// FillSpiralArray2D(array2D);
// PrintSpiralArray2D(array2D);


//=======================================
// ВАРИАНТ 2 - для любого массива:
//=======================================

// void PrintSpiralArray2D(int[,] array2D)
// {
//     for (int i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//             System.Console.Write(array2D[i, j].ToString("D2") + " "); // Добавлен вывод двузначного числа у значений до 10, для соответствия примеру в условиях.       
//         }

//         System.Console.WriteLine();
//     }
// }

// int[,] FillSpiralArray2D(int[,] array2D, int sizeArray)
// {
//     int rowSize = array2D.GetLength(0) - 1;
//     int columnSize = array2D.GetLength(1) - 1;
    
//     int rowStart = 0;
//     int columnStart = 0;
   
//     int step = 1;

//     while (step <= sizeArray * sizeArray)
//     {
//         for (int i = columnStart; i <= columnSize; i++)
//         {
//             array2D[rowStart, i] = step++;
//         }
//         rowStart++;

//         for (int i = rowStart; i <= rowSize; i++)
//         {
//             array2D[i, columnSize] = step++;
//         }
//         columnSize--;

//         for (int i = columnSize; i >= columnStart; i--)
//         {
//             array2D[rowSize, i] = step++;
//         }
//         rowSize--;

//         for (int i = rowSize; i >= rowStart; i--)
//         {
//             array2D[i, columnStart] = step++;
//         }
//         columnStart++;
//     }

//     return array2D;
// }

// int sizeArray = 5;
// int[,] array2D = new int[sizeArray, sizeArray];

// int[,] result = FillSpiralArray2D(array2D, sizeArray);
// PrintSpiralArray2D(result);

//=======================================
// ВАРИАНТ 3 - решение преподавателя, определены недостающие элементы, теперь решение применимо для массивов четных и нечетных размеров:
//=======================================

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

void SpiralFilling(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    double halfRows = array.GetLength(0) / 2;

    int k = 0;
    int currentElement = 1;
    for (int i = 0; i < halfRows; i++)
    {
        for (k = 0 + i; k < columns; k++)
        {
            array[i, k] = currentElement++;
        }
        columns--;

        for (k = i + 1; k < rows; k++)
        {
            array[k, rows - 1] = currentElement++;
        }

        for (k = columns - 1; k >= i; k--)
        {
            array[rows - 1, k] = currentElement++;
        }
        rows--;

        for (k = rows - 1; k >= i + 1; k--)
        {
            array[k, i] = currentElement++;
        }
    }
}
int size = 5;
int[,] array = new int[size, size];
SpiralFilling(array);
PrintArray(array);