// Задача 39:
// Написать программу, которая перевернет массив.
// [1, 2, 3, 4, 5] -> [5, 4, 3, 2, 1]

Console.Write($"Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
int ind = 0;

Console.WriteLine($"Введите элементы массива: ");
while (ind < size)
{
    Console.Write($"{ind}: ");
    arr[ind] = Convert.ToInt32(Console.ReadLine());
    ind++;
}
for (int i = 0; i < size; i++)
{
    if (i == 0) Console.Write($"[{arr[i]}, ");
    else if (i == size - 1) Console.WriteLine($"{arr[i]}]");
    else Console.Write($"{arr[i]}, ");
}

int sizeArr = size;
int tempElement = 0;
for (int j = 0; j < size / 2; j++)
{
    tempElement = arr[j];
    arr[j] = arr[sizeArr - 1];
    arr[sizeArr - 1] = tempElement;
    sizeArr--;
}

void PrintArr(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        if (i == 0) Console.Write($"[{mass[i]}, ");
        else if (i == mass.Length - 1) Console.WriteLine($"{mass[i]}]");
        else Console.Write($"{mass[i]}, ");
    }
}

PrintArr(arr);