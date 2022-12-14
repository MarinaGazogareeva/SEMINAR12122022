// 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void InputMatrix(int[,] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            matrix[m, n] = new Random().Next(-100, 100)/10; 
            Console.Write($"{matrix[m, n]} \t");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите количество строк: ");
string[] numbers = Console.ReadLine().Split(" ");
foreach (string n in numbers)
{
    Console.Write(n);
}

Console.Write("Введите количество столбцов: ");
string[] numbers = Console.ReadLine().Split(" ");
foreach (string m in numbers)
{
    Console.Write(m);
}

InputMatrix(matrix);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void InputMatrix(int[,] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            matrix[m, n] = new Random().Next(-100, 100)/10; 
            Console.Write($"{matrix[m, n]} \t");
        }
        Console.WriteLine();
    }
}
int ReleaseMatrix(int[,] matrix);
    
    if (n > matrix.GetLength(1) || m < matrix.GetLength(0))
    {
       Console.WriteLine($"такого элемента нет");
            }
            else 
            {
                Console.WriteLine($"значение элемента {GetLength(n)} строки и {GetLength(m)} столбца равно {GetLength[n-1,m-1]}");
            }

Console.Clear();
Console.Write("Введите размеры матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[0])];
Console.WriteLine("Двумерный массив: ");
InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Результат: ");
Console.WriteLine(ReleaseMatrix(matrix));

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


