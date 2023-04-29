// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все 
// чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Ниже введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
int number = 0;
Console.Write("Все четные числа до введённого числа -> ");

while( N > number)
{
  number = i * 2;
  
  if(number % 2 == 0 && number <= N)
  {
    Console.Write($"{number} ");
  }
  i++;
}



