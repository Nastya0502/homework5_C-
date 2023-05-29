// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов.
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
    Console.WriteLine();
}

int[] MaxElemAndIndex(int[] array)
{
    int[] result = new int[2];
    int maxElem = array[0];
    int maxElemIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxElem)
            maxElem = array[i];
        maxElemIndex = i;
        result[0] = maxElem;
        result[1] = maxElemIndex;
    }
    return result;
}

int[] MinElemAndIndex(int[] array)
{
    int[] result = new int[2];
    int minElem = array[0];
    int minElemIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > minElem)
            minElem = array[i];
        minElemIndex = i;
        result[0] = minElem;
        result[1] = minElemIndex;
    }
    return result;
}

double AverageElements(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        result += array[i];
    return result / array.Length;
}


double Mediana(int[] array)
{
    int[] resultArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        resultArray[i] = array[i];
    for (int i = 0; i < resultArray.Length - 1; i++)
    {
        for (int j = i + 1; j < resultArray.Length; j++)
        {
            if (resultArray[i] > resultArray[j])
                (resultArray[i], resultArray[j]) = (resultArray[j], resultArray[i]);
        }
    }
    
}

