// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// double [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     double[,] array = new double[rows, columns];
//     Random rand = new Random();
//     for(int i = 0; i < rows; i++)
//     for(int j = 0; j < columns; j++)
//     {
//         array[i, j] = rand.Next(minValue,maxValue) +rand.NextDouble();
//     }
//     return array;
// }
// void Show2dArray(double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
// }
// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// double[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);



// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.



// int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)

// {
//  int[,] array = new int[rows, columns];
//  for(int i = 0; i < rows; i++)
//  for(int j = 0; j < columns; j++)
//  array[i, j] = new Random().Next(minValue, maxValue + 1);
//  return array;
// }
// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
// }

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите индекс строки:");
// int rows=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите индекс столбика:");
// int column=Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);
// if(rows<myArray.GetLength(0)&&column<myArray.GetLength(1))
// Console.WriteLine("Число="+ myArray[rows,column]);

// else
// Console.WriteLine("Такого элемента нет");


// Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.

// int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)

// {
//  int[,] array = new int[rows, columns];
//  for(int i = 0; i < rows; i++)
//  for(int j = 0; j < columns; j++)
//  array[i, j] = new Random().Next(minValue, maxValue + 1);
//  return array;
// }
// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
// }

// void ArithmeticMean(int[,] array)
// {
    
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum += array[i, j];
//         }
//         Console.Write($"{ sum / array.GetLength(0)} ");
//     }
        
    
// }

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);
// ArithmeticMean(myArray);

