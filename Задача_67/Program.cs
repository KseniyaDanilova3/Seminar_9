// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetNumbersSum(number));

// возвращает сумму цифр
int GetNumbersSum(int number) 
{
      if (number == 0)
            return number % 10;     // возвращает остаток от деления (последний разряд)

      return GetNumbersSum(number / 10) + number % 10;
}