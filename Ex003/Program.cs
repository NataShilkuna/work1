// Напишите программуб которая на вход принимает число и выдаётб является ли число чётным 
//(делится ли оно на два без остатка)

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write(num % 2 == 0? "Да" : "Нет");

