// Задача 42:
// Напишите программу, которая будет переводить число из десятичной в двоичную СИ.
// 45 -> 101101

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
string rem = "";
while (num > 0)
{
    rem = (num % 2).ToString() + rem;
    num = num / 2; 
}
Console.WriteLine($"Число {num} в двоичном формате выглядит вот так: {rem}");