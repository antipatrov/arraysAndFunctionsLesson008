// Задача 56: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с 
//наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей 
//суммой элементов: 1 строка



/// summary - описание метода, 3 слэша
/// m - строчки, n - столбцы

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
int SumLineElements(int[,] tab, int i)
{
  int sumLine = tab[i,0];
  for (int j = 1; j < tab.GetLength(1); j++)
  {
    sumLine += tab[i,j];
  }
  return sumLine;
}
int [,] table = new int[3,4];
Filltable(table);
PrintMatrix(table);
Console.WriteLine($"Строка с минимальной суммой значений: ");

int minSumLine = 0;
int sumLine = SumLineElements(table, 0);
for (int i = 1; i < table.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(table, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}
//SumElementsLine(table\,4);

Console.WriteLine(minSumLine + 1);