//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.  

Console.WriteLine("Введите 1 числo: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 2 числo: ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 3 числo: ");
int numberC = int.Parse(Console.ReadLine());

int max = numberA;

if (max > numberB)
  {
    if (max > numberC)
    {
      System.Console.WriteLine($"MAX = {numberA}");
    }
    else
    {
      System.Console.WriteLine($"MAX = {numberC}");
    }
  }
  
else
  {
    if (numberB > numberC)
    {
      System.Console.WriteLine($"MAX = {numberB}");
    }
    else
    {
      System.Console.WriteLine($"MAX = {numberC}");
    }
  }
