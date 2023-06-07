﻿// Задача 40:
// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с такими сторонами.
// теорема о нервенстве треугольника: каждая сторона треугольника меньше суммы двух других его сторон.

int[] arr = new int[3];

Console.WriteLine($"Введите размеры сторон треугольника (*.*)");

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Сторона {i + 1}: ");
    arr[i] = int.Parse(Console.ReadLine());
}

if (arr[0] < arr[1] + arr[2] && arr[1] < arr[0] + arr[2] && arr[2] < arr[1] + arr[0])
{
    Console.WriteLine($"Треугольник со сторонами {arr[0]}, {arr[1]}, {arr[2]} существует)");
}
else Console.WriteLine($"Треугольник со сторонами {arr[0]}, {arr[1]}, {arr[2]} не существует!!!");