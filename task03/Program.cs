//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка). 

Console.WriteLine("Введите числo: ");
int s = int.Parse(Console.ReadLine());

if ((s % 2) == 0)
{
  System.Console.WriteLine("Это четное число");
}
else
{
  System.Console.WriteLine("Это не четное число");
}