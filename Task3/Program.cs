/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int GetNumber (string numStr)
{
    bool isNum = false;
    int num = 0;
    
 
    while (!isNum)
    {   
        if (int.TryParse(numStr, out num) && num > 0)
            isNum = true;
        else 
        {
            Console.WriteLine("Некорректный ввод числа. Введите число > 0:");
            numStr = Console.ReadLine() ?? "";
        }
    }
    return num;
}

void PrintRndArray (int len)
{
    int[] array = new int[len];
    Random rnd = new Random();

    Console.Write($"Рандомный массив из {len} элементов:[");
    for (int i = 0; i < array.Length-1; i++)
    {
        array[i] = rnd.Next(0, 1000);
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length-1] + "]");
}

Console.WriteLine("Введите колличество элементов массива");
int len = GetNumber(Console.ReadLine() ?? "");
PrintRndArray(len);
