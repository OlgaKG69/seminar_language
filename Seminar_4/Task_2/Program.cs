// Задача 27: Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int number){
    
    int counter = Convert.ToString(number).Length;
    int a = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      a = number - number % 10;
      result = result + (number - a);
      number = number / 10;
    }
   return result;
  }


int n = ReadInt("Введите число: ");
System.Console.WriteLine($"Сумма цифр в числе {n} = {Sum(n)}");