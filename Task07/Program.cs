// Напишите программу которая на вход принимает трёхзначное число и на выходе показывает третью 
// цифру этого числа
// 456 -> 6
// 782 -> 2
// 918 -> 8
Console.Write("Введите трёхзначное число -> ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
if(number > 999 && number < -999)
{
  Console.Write("Вы ввели не трёхзначное число - попробуйте снова");
}

else
{
   result = number % 10;
   Console.Write($"Последняя цифра числа {number} равна {result}.");
}
