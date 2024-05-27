// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.




int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

void OutputOfElementsFromTheEnd(int[] ArrayFromTheEnd, int i = 0)
{
    if (i == ArrayFromTheEnd.Length) return;
    OutputOfElementsFromTheEnd(ArrayFromTheEnd, i + 1);
    Console.Write($"{ArrayFromTheEnd[i]} ");
}

int[] arr = CreateArrayRndInt(10, 1, 100);
PrintArray(arr);
Console.WriteLine();
OutputOfElementsFromTheEnd(arr);