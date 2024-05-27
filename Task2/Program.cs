// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

int Ack(int num1, int num2)
{
    if (num1 == 0)
    {
        return num2 + 1;
    }
    else
    {
        if (num2 == 0)
        {
            return Ack(num1 - 1, 1);
        }
    }
    return Ack(num1 - 1, Ack(num1, num2 - 1));
}

Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());


int result = Ack(n, m);
Console.WriteLine($"{result}");