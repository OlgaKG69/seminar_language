// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// НАДО:
// 1. Запросить у пользователя числа M и N
// 2. Функция суммы натуальных чисел от M до N
// 3. Рекурсия функции

int Digit(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumMN(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + SumMN(m, n);
        return result;
    }
}

void MN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

int m = Digit("Введите число M: ");
int n = Digit("Введите число N: ");
MN(m, n);