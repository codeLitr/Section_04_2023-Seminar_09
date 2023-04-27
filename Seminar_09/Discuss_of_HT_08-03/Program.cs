// Обсуждение домашнего задания к Семинару №8:

// Задача 58:
// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// МОЙ ВАРИАНТ:

// void FillMatrix(int[,] arrayMatrix) // Создание и заполнение двух двумерных массивов (матриц).
// {
//     Random random = new Random();
//     for (int i = 0; i < arrayMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayMatrix.GetLength(1); j++)
//         {
//             arrayMatrix[i, j] = random.Next(1, 10);
//         }
//     }
// }

// void PrintTwoMatrix(int[,] matrixLeft, int[,] matrixRight) // Вывод массива в консоль в формате в соответствии с заданием. 
// {
//     for (int i = 0; i < matrixLeft.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixLeft.GetLength(1); j++)
//         {
//             Console.Write(matrixLeft[i, j] + " ");
//         }
//         Console.Write("| ");

//         for (int j = 0; j < matrixRight.GetLength(1); j++)
//         {
//             Console.Write(matrixRight[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void PrintResultMatrix(int[,] arrayMatrix) 
// // Отдельный метод для вывода результата - сделан, в связи с форматом вывода изначальных двух матриц. 
// // При исключении разделителя матриц и выводе их друг под другом, возможно использование одного метода для всех выводов в консоль.
// {
//     for (int i = 0; i < arrayMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayMatrix.GetLength(1); j++)
//         {
//             System.Console.Write("{0,4}", arrayMatrix[i, j] + " ");
//         }

//         System.Console.WriteLine();
//     }
// }

// int[,] MultiplyMatrix(int[,] matrixLeft, int[,] matrixRight) // Перемножение двух матриц.
// {
//     int[,] resultM = new int[matrixLeft.GetLength(0), matrixRight.GetLength(1)];

//     for (int i = 0; i < matrixLeft.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixRight.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrixLeft.GetLength(1); k++)
//             {
//                 resultM[i, j] += matrixLeft[i, k] * matrixRight[k, j];
//             }
//         }
//     }

//     return resultM;
// }

// int rows = 3;
// int columns = 3;
// int[,] matrixLeft = new int[rows, columns];
// int[,] matrixRight = new int[rows, columns];

// FillMatrix(matrixLeft);
// FillMatrix(matrixRight);
// PrintTwoMatrix(matrixLeft, matrixRight);
// System.Console.WriteLine();

// int[,] result = MultiplyMatrix(matrixLeft, matrixRight);
// PrintResultMatrix(result);



// ВАРИАНТ ПРЕПОДАВАТЕЛЯ:

void RandomNumberMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] array)
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

int[,] ResultMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
}

int n = 4;
int m = 3;
int[,] matrix1 = new int[n, m];
int[,] matrix2 = new int[m, n];

RandomNumberMatrix(matrix1);
RandomNumberMatrix(matrix2);
PrintMatrix(matrix1);
PrintMatrix(matrix2);
int[,] result = ResultMatrix(matrix1, matrix2);
PrintMatrix(result);