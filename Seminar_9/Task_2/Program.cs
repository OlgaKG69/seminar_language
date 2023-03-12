// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

//          = n + 1                     m = 0
// A(m, n)  = A (m - 1, 1)              m > 0, n = 0
//          = A (m - 1, A(m, n - 1))    m > 0, n > 0

int Number(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Akkerman(int m, int n)
{
    Console.Write(AkkFunction(m, n));
}

int AkkFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkFunction(m - 1, 1);
    }
    else
    {
        return (AkkFunction(m - 1, AkkFunction(m, n - 1)));
    }
}

int m = Number("Введите число m: ");
int n = Number("Введите число n: ");
Akkerman(m, n);