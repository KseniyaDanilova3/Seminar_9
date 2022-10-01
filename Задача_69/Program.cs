// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{A} ^ {B} = {GetAPowB(A, B)}");

int GetAPowB(int A, int B)
{
      if (B == 0)
            return 1;
      
      return GetAPowB(A, B - 1) * A; 
}


