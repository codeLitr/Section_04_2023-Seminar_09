// Обсуждение домашнего задания к Семинару №7:

// Задача 50:
// Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же
// указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// МОЙ ВАРИАНТ:

// int[,] CreateAndFillArray2D(int rows, int columns, int leftRangeValue, int rightRangeValue)
// {
//     int rowsRnd = new Random().Next(1, rows + 1);
//     //int rowsRnd = rows; // Для проверки работоспособности (без рандомайзера) необходимо раскомментировать данную строки и закомментировать строку выше.
//     int columnsRnd = new Random().Next(1, columns + 1);
//     //int columnsRnd = columns; // Для проверки работоспособности (без рандомайзера) необходимо раскомментировать данную строки и закомментировать строку выше.

//     int[,] array2D = new int[rowsRnd, columnsRnd];

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
//             System.Console.Write(array2D[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void LetsPlayGame(int[,] array2D, int rowPos, int columnPos)
// {
//     if (rowPos >= 0 && rowPos < array2D.GetLength(0) && columnPos >= 0 && columnPos < array2D.GetLength(1))
//     {
//         Console.WriteLine($"Поздравляю, Вы угадали, число на позиции {rowPos} и {columnPos} -> {array2D[rowPos, columnPos]}");
//         System.Console.WriteLine();
//     }
//     else
//     {
//         Console.WriteLine($"{rowPos} и {columnPos} -> Такого числа в массиве нет.");
//         System.Console.WriteLine();
//     }
// }

// System.Console.WriteLine();
// System.Console.WriteLine("Добро пожаловать в игру - Угадай, есть ли такая позиции в двумерном массиве!");
// System.Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
// System.Console.WriteLine();
// System.Console.WriteLine("Сейчас Вам понадобится ввести диапазон, в котором будут случайным образом определены кол-во строк и столбцов.");
// System.Console.WriteLine();

// System.Console.Write("Введите максимальное желаемое кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите максимальное желаемое кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array2D = CreateAndFillArray2D(rows, columns, 0, 10);

// System.Console.WriteLine();
// System.Console.WriteLine("А теперь введите позицию в массиве. Кто знает, может Вам повезет и Вы угадаете с первого раза!");
// System.Console.WriteLine();
// System.Console.Write("Введите позицию строки: ");
// int rowPos = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите позицию столбца: ");
// int columnPos = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine();
// PrintArray2D(array2D);
// System.Console.WriteLine();

// LetsPlayGame(array2D, rowPos, columnPos);




// ВАРИАНТ ПРЕПОДАВАТЕЛЯ:

void FillArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = i + j;
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

int GetNumberByIndex(int i, int j, int[,] array2D)
{
    return array2D[i, j];
}

bool IsIndexExist(int i, int j, int[,] array2D)
{
    int rows = array2D.GetLength(0);
    int columns = array2D.GetLength(1);
    return ((i >= 0) && (i < rows) && (j >= 0) && (j < columns));
}

int[,] matrix = new int[5, 5];
int line = Convert.ToInt32(Console.ReadLine());
int column = Convert.ToInt32(Console.ReadLine());
FillArray2D(matrix);
PrintArray2D(matrix);

if (IsIndexExist(line, column, matrix))
{
    System.Console.WriteLine(GetNumberByIndex(line, column, matrix));
}
else
{
    System.Console.WriteLine("Такого элемента не существует");
}