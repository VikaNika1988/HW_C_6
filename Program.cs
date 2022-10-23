//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите числа: ");
int[] array = GetArray5(5);
Console.WriteLine($"В массиве [ {String.Join("| ", array)} ]");
Console.WriteLine($"[{NumPositive(array)}] чисел больше 0:  .");

int NumPositive(int[] collection)
{
    int result = 0;
    for (int i = 0; i < collection.Length; i++)
    {       
        if(collection[i] > 0) result += 1;
    } 
    return result;
}

int[] GetArray5(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = int.Parse(Console.ReadLine()!);
    }
    return res;
}


/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/ 
Console.WriteLine("Введите b1: ");
double b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k1: ");
double k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2: ");
double b2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2: ");
double k2 = int.Parse(Console.ReadLine()!);

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"точку пересечения двух прямых: [{x}; {y}]");