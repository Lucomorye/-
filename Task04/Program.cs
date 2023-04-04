// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих 
// чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Ниже введите три числа:");
Console.Write("Первое число -> ");
int fistNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число -> ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Третье число -> ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int max = fistNumber;

if (secondNumber > max && secondNumber > thirdNumber )
{
  max = secondNumber;
}
if (thirdNumber > max)
{
  max = thirdNumber;
}
Console.Write($"Максимальное число -> {max}");


