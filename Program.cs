// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// double[,] GenerateArray(int rows, int columns)
// {
//     double[,] array = new double[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(5, 10)) / 10;
//         }
//     }
//     return array;
// }

// void PrintArray(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }
// double[,] myArray = GenerateArray(3, 3);
// PrintArray(myArray);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает з
// начение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет


// int[,] GenerateArray(int rows)
// {
//     int[,] array = new int[rows, rows];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i + j+1;
//         }
//     }
//     return array;
// }
// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }
// int String(string message)
// {
//     System.Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int Collum(string message)
// {
//     System.Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int FindDigitOnArray(int[,] array, int Str, int Coll)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (Str == i && Coll == j)
//             {
//                 return array[i, j];
//             }
//         }
//     }
//     return 0;
// }
// int[,] NewArray = GenerateArray(3);
// PrintArray(NewArray);
// int Str = String("Введите строку числа в массиве: ");
// int Coll = Collum("Введите столбец числа в массиве: ");
// int result = FindDigitOnArray(NewArray, Str, Coll);
// if (result == 0)
// {
//     System.Console.WriteLine($"{Str}, {Coll} -> такого числа в массиве нет");
// }
// else
// {
//     System.Console.WriteLine($"{result} -> это число в заданной позиции");
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// int[,] GenerateArray(int rows, int columns, int minRnd, int maxRnd)
// {
//     int[,] array = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(minRnd, maxRnd);
//         }
//     }
//     return array;
// }
// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

//   void rowWiseAvg(int[,] matrix)
// {
//     Console.WriteLine(matrix.GetLength(0));
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
//     double sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         sum += matrix[i, j];
//     }
//     Console.Write($"{ sum / matrix.GetLength(0)} ");
// }
// Console.ReadLine();
// }

// int [,] NewArray = GenerateArray(3, 3, 1, 6);
// PrintArray(NewArray);
// rowWiseAvg(NewArray);