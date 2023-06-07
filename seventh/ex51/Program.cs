// задача 51:
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
// (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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

int SumMainDiagonal(int[,] arr)
{
    int sum = 0;
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int n = 0; n < arr.GetLength(1); n++)
        {
            if (m == n)
            {
                sum = sum + arr[m, n];
            }
        }
    }
    return sum;
}

Console.Write("Сколько строк: ");
int m = InputNumber();
Console.Write("Сколько столбцов: ");
int n = InputNumber();
int[,] array = new int[m, n];

FillMatrix(array);
PrintMatrix(array);
Console.WriteLine($"Сумма элементов главной диагонали: {SumMainDiagonal(array)}");