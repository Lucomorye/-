// Напишите программу которая на вход принимает двузначное число а на выход показывает большую цифру числа.
/*int Digit(int number)
{
int ed = number % 10;
int des = number / 10;    Возвратный метод

if (ed > des)
{
  return ed;
}
else
{
  return des;
}
}*/
void Digit1(int number)
{
  int ed = number % 10;
  int des = number / 10;

  if (ed > des)
  {
    Console.WriteLine("The bigest digit is " + ed);
  }
  else
  {
    Console.WriteLine("The bigest digit is " + des);
  }
}
Console.WriteLine("input number");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number > 9 && user_number < 100)
{
  Digit1(user_number);
  //int res = Digit(user_number);
  //Console.WriteLine($"The biggest digit is {res} ");
}
else
{
  Console.WriteLine("impossible value ");
}
