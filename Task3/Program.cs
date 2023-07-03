/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое* элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
* Сумма всех цифр / их количество(это количество ваших строк)*/

int[,] array = GetArray(4, 4, 0, 10);
PrintArray(array);
PrintArithmeticMean(array);


int[,] GetArray(int m, int n, int MinValue, int MaxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(MinValue, MaxValue);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void PrintArithmeticMean(int[,] array)
{
    double ArithmeticMean;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        ArithmeticMean = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            ArithmeticMean += array[j, i];
        }
        ArithmeticMean = ArithmeticMean / array.GetLength(0);
        Console.WriteLine($"Среднее арифметическое столбца {i + 1}: {ArithmeticMean}");
    }
}