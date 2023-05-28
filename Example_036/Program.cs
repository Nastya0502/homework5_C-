// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i=0; i<array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}]");
    Console.WriteLine();
}

int SumOddIndexElements (int[] array)
{
    int result = 0;
    for (int i = 1; i<array.Length; i+=2)
        result+=array[i];
    return result;
}


Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[n];
FillArray(arrayNumbers);
PrintArray(arrayNumbers);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {SumOddIndexElements(arrayNumbers)}");