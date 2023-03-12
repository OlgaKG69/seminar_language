// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// НАДО:
// 1. Функция заполнения массива рандомно числами от 1 до 9
// 2. Функция сортировки элементов в строке двумерного массива по убыванию
// 3. Функция вывода двумерного массива

int[,] order = new int[3, 4];

// 1
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// 2
void Sort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(1) - 1; l++)
            {
                if (array[i, l] < array[i, l + 1])
                {
                    int coup = array[i, l + 1];
                    array[i, l + 1] = array[i, l];
                    array[i, l] = coup;
                }
            }
        }
    }
}

// 3
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillArray(order);
PrintArray(order);
Sort(order);
Console.WriteLine();
PrintArray(order);