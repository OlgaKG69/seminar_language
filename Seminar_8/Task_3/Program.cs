// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// НАДО:
// 1. Функция заполнения 3D массива неповторяющимеся двузначными числами (тип[,...,] имя_массива = new тип[размер1, размер2, ... размеры]; 
// трехмерный массив C#: int[,,] myArr = new int[5,5,5];)
// 2. Функция вывода индекса элементов 3D массива

int[,,] arr3D = new int[2, 2, 2];

// 1
void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int l = 0; l < arr.GetLength(2); l++)
            {
                arr[l, i, j] += count;
                count += 3;
            }
        }
    }
}

// 2
void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int l = 0; l < arr3D.GetLength(2); l++)
            {
                Console.Write($"{arr3D[i, j, l]}({i},{j},{l}) ");
            }
        }
    }
}


FillArray(arr3D);
PrintIndex(arr3D);