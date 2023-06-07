// Задача 49: 
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

void SwapEvenIndexForSquares(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            if (m % 2 == 0 && n % 2 == 0)
            {
                array[m, n] = Convert.ToInt32(Math.Pow(array[m, n], 2));
            }
        }
    }
}

int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void FillMatrix(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int m = InputNumber();
Console.Write("Введите количество столбцов: ");
int n = InputNumber();
int[,] arr = new int[m, n];

FillMatrix(arr);
PrintMatrix(arr);
Console.WriteLine("Матрица послее замены:");
SwapEvenIndexForSquares(arr);
PrintMatrix(arr);