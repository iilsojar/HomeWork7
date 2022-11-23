// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет


Console.Clear();
Console.Write("Введите номер строки: ");
int rowsnumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int columnsnumber = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [10,10];

FillArray(array);
PrintArray(array);

if (rowsnumber > array.GetLength(0) || columnsnumber > array.GetLength(1))
    {
        Console.WriteLine("такого элемента нет");
    }
else
    {
        Console.WriteLine($"значение элемента {rowsnumber} строки и {columnsnumber} столбца равно {array[rowsnumber-1, columnsnumber-1]}");
    }

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}