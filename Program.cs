// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
//вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

//double [,] createArray(int rows, int columns)
//{
//        double [,] array = new double[rows, columns];
//        Random random = new Random();
//        for (int i = 0; i < array.GetLength(0); i++) 
//        {
//                for (int j = 0; j < array.GetLength(1); j++) 
//                {
//                        array[i, j] = random.Next(-9, 10) + random.NextDouble(); // задали вывод случайных, вещественных элементов массива
//                }
//        } 
//        return array; 
//}
//
//void showArray(double[,] array) 
//{
//        for (int i = 0; i < array.GetLength(0); i++)
//        {
//                for (int j = 0; j < array.GetLength(1); j++)
//                {
//                        Console.Write($"{array[i, j]:f1}\t");// форматирование массиаа при выводе
//                 }
//                System.Console.WriteLine(); 
//        }
//}
//
//double[,] array = createArray(3, 4); 
//showArray(array);         

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
//двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
//Console.WriteLine("Input your row");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input your column");
//int m = Convert.ToInt32(Console.ReadLine());
//int [,] numbers = new int [3,4];
//FillArrayRandomNumbers(numbers);
//    if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
//    {
//    Console.WriteLine("Try next time");
//    }
//    else
//    {
//    Console.WriteLine($"your {n} row and {m} column is {numbers[n-1,m-1]}");
//    }
//        
//ShowArray(numbers);
//        
//void FillArrayRandomNumbers(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//        for (int j = 0; j < array.GetLength(1); j++)
//        array [i,j] = new Random().Next(-100, 100)/10;          
//    }
//void ShowArray(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//        {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//Console.Write(array[i,j] + " ");
//}
//Console.WriteLine("");
//}
//}
//Задача 52. Задайте двумерный массив из 
//целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Random random = new Random();
//int[,] array = new int[random.Next(3, 5), random.Next(3, 5)];
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        array[i, j] = random.Next(1, 10);
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine(" ");
//
//Console.WriteLine(array.GetLength(0));
//for (int j = 0; j < array.GetLength(1); j++)
//{
//    double sum = 0;
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        sum += array[i, j];
//    }
//    Console.Write($"{ sum / array.GetLength(0):f1}\t ");
//    }
//Console.ReadLine();
