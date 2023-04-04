// Напишите программу, которая на вход принимает два числа и выдаёт, какое число больше, а какое меньше.
// а = 5, в = 7 -> max = 7
// а = 2, в = 10 -> max = 10
// а = -9, в = -3 -> max = -3
Console.WriteLine("Ниже введите два числа:");

Console.Write("Первое число -> ");
int fistNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число -> ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int max;

if (fistNumber > secondNumber)
{
  max = fistNumber;
}
else
{
  max = secondNumber;
}
Console.WriteLine($"Максимальное число -> {max}");
