// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int m, int n)
{
    int[,] matrix = new int [m, n];
    Random rand = new Random();
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            matrix[i,j] = rand.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}
int m = ReadInt("Введите количество строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");

var myMatrix = GenerateMatrix(m, n);
PrintMatrix(myMatrix);

int a = ReadInt("Введите номер строки матрицы: ");
int b = ReadInt("Введите номер столбца матрицы: ");

 if (a>m && b>n)
 Console.WriteLine("такого числа нет");
 else
 {
 object c = myMatrix.GetValue(a, b);
 Console.WriteLine(c);
 }


