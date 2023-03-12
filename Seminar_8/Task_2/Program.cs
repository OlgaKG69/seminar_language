// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// НАДО:
// 1. Создать две матрицы
// 2. Создать финальную матрицу, заполненную произведением двух предыдущих
// 3. Функция запроса данных от пользователя
// 4. Функция заполнения матриц
// 5. Функция вывода матриц
// 

int m = ReadInt("Введите количество строк: ");
int n = ReadInt("Введите количество столбцов: ");
int[,] matrix = new int[m, n];
int[,] secondMatrix = new int[m, n];
int[,] finallyMatrix = new int[m, n];

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
FillMatrix(secondMatrix);
PrintMatrix(secondMatrix);
Console.WriteLine();

if (matrix.GetLength(0) != secondMatrix.GetLength(1))
{
    Console.WriteLine(" Операция невозможна ");
    return;
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        finallyMatrix[i, j] = 0;
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            finallyMatrix[i, j] += matrix[i, l] * secondMatrix[l, j];
        }
    }
}

PrintMatrix(finallyMatrix);


