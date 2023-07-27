// Напишите программу,которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание,что такого элемента нет.
// Например задан массив: 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void Print2DArray(int[,] array)
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

int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
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

int GetElementFromPosition(int[,] array, int row, int column)
{
    if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
    {
        return array[row, column];
    }
    else
    {
        return -1;
    }
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInput("Введите количество строк массива: ");
int columns = GetInput("Введите количество столбцов массива: ");
int[,] array = Create2DArray(rows, columns, 1, 9);

Console.WriteLine("Двумерный массив:");
Print2DArray(array);

int row = GetInput("Введите номер строки элемента: ");
int column = GetInput("Введите номер столбца элемента: ");
int element = GetElementFromPosition(array, row, column);

if (element != -1)
{
    Console.WriteLine($"Значение элемента на позиции ({row}, {column}): {element}");
}
else
{
    Console.WriteLine("Такого элемента нет в массиве.");
}