/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Введите первое число:");
string numStr1 = Console.ReadLine() ?? "";

if (!int.TryParse(numStr1, out int num1)) 
{
    Console.WriteLine("Вы ввели не число");
    return;
}

Console.WriteLine("Введите второе число >0 :");
string numStr2 = Console.ReadLine() ?? "";

if (!int.TryParse(numStr2, out int num2)) 
{
    Console.WriteLine("Вы ввели не число");
    return;
}

if (num2 > 0)
{
Console.WriteLine($"{num1} в степени {num2} = " + Math.Pow(num1, num2));
}
else Console.WriteLine("Второе число должно быть >0");