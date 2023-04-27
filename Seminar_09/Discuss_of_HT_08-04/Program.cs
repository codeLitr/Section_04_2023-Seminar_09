// Обсуждение домашнего задания к Семинару №8:

// Задача 60: 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// МОЙ ВАРИАНТ:

// ...



// ВАРИАНТ ПРЕПОДАВАТЕЛЯ:

void FillArray(int[,,] array) //!!!! Добавить перезапуск, в случае создания повторяющихся цифр. В остальном все ОК.
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
                array[a,b,c] = new Random().Next(10, 100);
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
                Console.Write($"{array[a,b,c]} ({a} {b} {c}) {" "}");
            }
            System.Console.WriteLine();
        }
    }
}

int[,,] array = new int[2, 2, 2];
FillArray(array);
PrintArray(array);