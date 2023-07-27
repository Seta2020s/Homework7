// Задайте двумерный массив размером m×n,заполненный случайными вещественными числами.
// m = 3, n =4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 87,8 -7,19

double[,] Create2DMassive(int rows, int columns, double minValue, double maxValue)
{
    double[,] matrix = new double[rows, columns];
    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            double randomValue = minValue + random.NextDouble() * (maxValue - minValue);
            matrix[i, j] = randomValue;
        }
    }

    return matrix;
}

void Print2DMassive(double[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]:F1} ");
        }
        Console.WriteLine();
    }
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите количество строк массива: ");
int n = GetInput("Введите количество столбцов массива: ");
double[,] massive = Create2DMassive(m, n, -10.0, 10.0);

Console.WriteLine("\nМассив:");

Print2DMassive(massive);