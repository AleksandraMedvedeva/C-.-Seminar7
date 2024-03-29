// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
void che(int m, int n)
{
    if (m > n)
        return;
    else
    {
        Console.Write($"{ m}, ");
    }
    che(m + 1, n);
}
che(m, n);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

int akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
    {
        if (n == 0)
            return akkerman(m - 1, 1);
        else
            return akkerman(m - 1, akkerman(m, n - 1));
    }

}

Console.Write($"Функция Аккермана равна {akkerman(m, n)} ");

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 10);
}

int[] ArraySwap(int[] array, int index)
{
    if (index <= 0)
    {
        return array;
    }
    int temp = array[index];
    array[index] = array[array.Length - index-1];
    array[array.Length - index-1] = temp;
    return ArraySwap(array, index -= 2);
}
Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine(string.Join(", ", array));
ArraySwap(array, array.Length-1);
Console.WriteLine(string.Join(", ", array));

