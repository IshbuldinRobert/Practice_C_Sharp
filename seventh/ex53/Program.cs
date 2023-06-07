// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

void ChangeRowsInMatrix2(int[,] arr)
{
    int temp;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == 0)
            {
                temp = arr[i, j];
                arr[i, j] = arr[arr.GetLength(0) - 1, j];
                arr[arr.GetLength(0) - 1, j] = temp;
            }
        }
    }
}

Console.Write("Введите количество строк: ");
int m = InputNumber();
Console.Write("Введите количество столбцов: ");
int n = InputNumber();
int[,] array = new int[m, n];
FillMatrix(array);
PrintMatrix(array);
Console.WriteLine();
ChangeRowsInMatrix2(array);
PrintMatrix(array);