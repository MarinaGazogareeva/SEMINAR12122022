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


