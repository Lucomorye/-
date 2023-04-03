// Напишите программу которая на вход принимает число, а на выход выводит его квадрат
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
//или string str = Console.ReadLine();
//    int number = Convert.ToInt32(str);
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");
