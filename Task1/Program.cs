// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//  Использовать рекурсию, не использовать циклы.

void NumbersInTheRangeFromMtoN(int num1, int num2)
{
    if (num1 == num2) return;
    if (num1 < num2)
    {
        Console.Write($"{num1} ");
        NumbersInTheRangeFromMtoN(num1 + 1, num2);
    }
    else
    {
        if (num1 > num2)
            Console.Write($"{num1} ");
        NumbersInTheRangeFromMtoN(num1 - 1, num2);
    }
}

Console.WriteLine("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());

NumbersInTheRangeFromMtoN(M, N);
Console.Write($"{N}");