// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000, 1001)/10.0;
    }
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i=0; i<array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}]");
    Console.WriteLine();
}

double MinElement(double[] array)
{
    double resMin = array[0];
    for (int i = 0; i< array.Length; i++)
    {
        if (array[i]<resMin)
            resMin = array[i];
    }
    return resMin;
}

double MaxElement(double[] array)
{
    double resMax = array[0];
    for (int i = 0; i< array.Length; i++)
    {
        if (array[i]>resMax)
            resMax = array[i];
    }
    return resMax;
}

double DiffefenceMaxMin(double max, double min)
{
    double result = 0;
    result = max-min;
    return result;
}



Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] arrayNumbers = new double[n];
FillArray(arrayNumbers);
PrintArray(arrayNumbers);
Console.WriteLine($"Разница между максимальным и минимальным элемен6тами массива: {DiffefenceMaxMin(MaxElement(arrayNumbers), MinElement(arrayNumbers))}");