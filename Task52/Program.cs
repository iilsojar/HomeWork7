// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine() ?? "0") ;

Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine() ?? "0");

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);


int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = new Random().Next(min, max + 1);
            }
        }
    return result;
}

for (int j = 0; j < array.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avarage = (avarage + array[i, j]);
    }
    avarage = avarage / rows;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(array);
void PrintArray(int [,] InArray)
{
        for (int i = 0; i < InArray.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < InArray.GetLength(1); j++)
            {
                Console.Write($"{InArray[i, j]} ");
            }
            Console.Write("]");
            Console.WriteLine(""); 
        }
}

