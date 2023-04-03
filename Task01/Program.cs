// Напишите программу которая на вход пренимает два числа и определяет евляется ли первое число 
// квадратом второго.
// а = 25, b = 5 -> yes
// а = 2, b = 10 -> no
// а = 9, b = -3 -> yes
// а = -3, b = 9 -> no
Console.Write("Введите первое число -> ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число -> ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber % secondNumber == 0)
{
  Console.WriteLine($"Да число {firstNumber} является квадратом числа {secondNumber}");
}

else
{
  Console.WriteLine($"Нет число {firstNumber} не является квадратом числа {secondNumber}");
}
