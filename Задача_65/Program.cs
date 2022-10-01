// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N по убыванию.
// M = 1; N = 5 -> "5, 4, 3, 2, 1"
// M = 4; N = 8 -> "8, 7, 6, 5, 4"

Console.Write("Введите первое число: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int N = int.Parse(Console.ReadLine()!);

int rangeMin = Min(M, N);
int rangeMax = Max(M, N);

Console.WriteLine(GetNaturalRowBetweenMN(rangeMin, rangeMax));

int Min(int a, int b)
{
      return a < b ? a : b; 
}

int Max(int a, int b)
{
      return a > b ? a : b; 
}




string GetNaturalRowBetweenMN (int rangeMin, int rangeMax)
{
      {
      if (rangeMax == rangeMin) 
            return rangeMax.ToString();
      
      return rangeMax + ", " + GetNaturalRowBetweenMN(rangeMin, rangeMax - 1);
      }
}