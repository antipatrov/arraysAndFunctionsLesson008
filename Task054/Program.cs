// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");

        }
        Console.WriteLine();
    }
}

void Filltable(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}
void ReductionElements(int[,] table)
{

    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {

            for (int k = 0; k < table.GetLength(1) - 1; k++)
            {
                if (table[i, k] < table[i, k + 1])
                {
                    int temp = table[i, k + 1];
                    table[i, k + 1] = table[i, k];
                    table[i, k] = temp;
                }
            }

        }
    }
}

int [,] table = new int[3,4];

Filltable(table);
PrintMatrix(table);
Console.WriteLine($"Отсортированный массив: ");
ReductionElements(table);
PrintMatrix(table);
