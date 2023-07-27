// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например,задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintTwoDimensionalArray(int[,] array)
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

int[,] GenerateRandomIntArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(minValue, maxValue + 1);
        }
    }

    return array;
}

double[] CalculateColumnAverages(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    double[] columnSums = new double[columns];
    double[] columnAverages = new double[columns];

    for (int j = 0; j < columns; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            columnSums[j] += array[i, j];
        }

        columnAverages[j] = columnSums[j] / rows;
    }

    return columnAverages;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInput("Введите количество строк массива: ");
int columns = GetInput("Введите количество столбцов массива: ");
int[,] intArray = GenerateRandomIntArray(rows, columns, 1, 9);

Console.WriteLine("Двумерный массив:");
PrintTwoDimensionalArray(intArray);

double[] columnAverages = CalculateColumnAverages(intArray);

Console.WriteLine("Среднее арифметическое каждого столбца:");
for (int j = 0; j < columns; j++)
{
    Console.Write($"{columnAverages[j]:F1} ");
}