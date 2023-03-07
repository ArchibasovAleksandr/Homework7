// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


// int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//   int [,] newArray = new int [rows, colums];
//   for (int i = 0; i < rows; i++)
//   {
//       for (int j = 0; j < colums; j++)
//       {
//         newArray[i, j] = new Random().Next(minValue, maxValue+1);
//       }
//   }
//   return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void FindNumber (int[,] array, int positionI, int positionJ)
// {
//     if((positionI <= array.GetLength(0)) && (positionJ <= array.GetLength(1)))
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//             if((i == positionI) && (j == positionJ)) 
//             {
//                 Console.WriteLine(array[i , j]);
//             }
//             }          
//         } 
//     }
//     else
//     {
//         Console.WriteLine($"Такого числа в массиве нет");
//     }
// }

// Console.WriteLine("Введите размер ряда");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер столбцов");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента массива");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента массива");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input positionI");
// int positionI = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input positionJ");
// int positionJ = Convert.ToInt32(Console.ReadLine());

// int [,] array = Create2DRandomArray(colums, rows, minValue, maxValue);
// Show2DArray(array);
// FindNumber(array, positionI, positionJ);







// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2

// double[,] CreatRandomArray(int colums, int rows, int minValue, int maxValue) // создаёт массив 
// { 
//     double[,] array = new double[rows,colums]; 
//     Random rand = new Random(); 
//     for (int i = 0; i < rows; i++)
//     {
//       for (int j = 0; j < colums; j++) 
//     { 
//         array[i,j] = rand.Next(minValue, maxValue + 1) + Math.Round(rand.NextDouble(), 2); 
//     }  
//     } 
//     return array;
// }
 
// void Show2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите размер ряда");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер столбцов");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента массива");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента массива");
// int maxValue = Convert.ToInt32(Console.ReadLine());
 
// double[,] array = CreatRandomArray(colums, rows, minValue, maxValue); 
// Show2DArray(array); 






// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int[,] Create2DRandomArray(int rows, int colums, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void FindAverage(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         int sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum = sum + array[i,j]; 
//         }
//         Console.WriteLine((double) sum / array.GetLength(0));
//     }      
//     Console.WriteLine();
// }   

// Console.WriteLine("Введите размер ряда");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер столбцов");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента массива");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента массива");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int [,] array = Create2DRandomArray(colums, rows, minValue, maxValue);
// Show2DArray(array);
// Console.WriteLine();
// FindAverage(array);
    


