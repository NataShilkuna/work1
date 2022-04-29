// Напишите программу, которая приминает на вход три числа и выдаёт максимальное из этих числел.
Console.WriteLine("Введите два числа: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("max={0}", Math.Max(num1,num2));