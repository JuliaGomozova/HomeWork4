/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
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

int GetSum (int num)
{  
    int sum = 0;
    
    for (int i = Math.Abs(num); i > 0; i /= 10)
    {
        sum = sum + (i % 10);
    }

    return sum;
}

Console.WriteLine("Введите число:");
int num = GetNumber(Console.ReadLine() ?? "");
int sum = GetSum(num);
Console.WriteLine($"Сумма всех цифр в числе {num} = {sum}");