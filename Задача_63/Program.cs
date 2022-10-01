// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Write("ВВедите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetNaturalRow(N));

string GetNaturalRow (int N)
{
      if (N == 1) 
            return "1";
      
      return GetNaturalRow(N - 1) + ", " + N;
}