// Задача 48:
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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
            array[m, n] = m + n;
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

Console.Write("Введите количестко строк: ");
int m = InputNumber();
Console.Write("Введите количестко столбцов: ");
int n = InputNumber();
int[,] arr = new int[m, n];
FillMatrix(arr);
PrintMatrix(arr);