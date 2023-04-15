Console.WriteLine("Введите 1 числo: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 2 числo: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
  {
    System.Console.WriteLine($"MAX = {numberA}");
  }
  else if (numberA == numberB)
  {
    System.Console.WriteLine($"Числа равны");
  }
else
  {
    System.Console.WriteLine($"MAX = {numberB}");
  }