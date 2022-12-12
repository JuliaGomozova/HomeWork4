/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int GetNumber (string numStr)
{
    bool isNum = false;
    int num = 0;
    
    while (!isNum)
    {   
        if (int.TryParse(numStr, out num))
            isNum = true;
        else 
        {
            Console.WriteLine("Вы ввели не число, введите число:");
            numStr = Console.ReadLine() ?? "";
        }
    }
    return num;
}

Console.WriteLine("Введите первое число:");
int num1 = GetNumber(Console.ReadLine() ?? "");

Console.WriteLine("Введите второе число > 0:");
int num2 = GetNumber(Console.ReadLine() ?? "");

while (num2 <= 0)
{
     Console.WriteLine("Второе число должно быть >0");
     Console.WriteLine("Введите второе число > 0:");
     num2 = GetNumber(Console.ReadLine() ?? "");
}

Console.WriteLine($"{num1} в степени {num2} = " + Math.Pow(num1, num2));
