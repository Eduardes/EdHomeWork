﻿// Задача № 47. Задайте двумерный массив M,N, заполненный случайными вещественными числами.

/*double[,] CreateRandom2dArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
        {    array[i,j] = new Random().NextDouble();
             array[i,j] = Math.Round(array[i,j], 2);
        }    
    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++ )
    {
        for(int j =0; j < array.GetLength(1); j++)
           Console.Write(array[i,j] + " ");

        Console.WriteLine();   
    }
}

Console.Write("Input f number of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int m = Convert.ToInt32(Console.ReadLine());
//Console.Write("Input a min possible value: ");
//int min = Convert.ToInt32(Console.ReadLine());
//Console.Write("Input a max possible value: ");
//int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(n, m);
Show2dArray(myArray);*/

//Задача № 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве и
// возвращает значение этого элемента или укажет, что такого элемента нет.

/*int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue+1);
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++ )
    {
        for(int j =0; j < array.GetLength(1); j++)
           Console.Write(array[i,j] + " ");

        Console.WriteLine();   
    }
}

Console.Write("Input f number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("input a index i: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a index j: ");
int j = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
void ElementArray(int[,] myArray)
{ 
  if( i < myArray.GetLength(0) &&  j < myArray.GetLength(1))
  {
    Console.Write($"Элемент массива: " + myArray[i,j]);
  }
  else
  {
      Console.WriteLine("Такого элемента нет");
  }  
}
ElementArray(myArray);*/

//Задача № 52. Задайте двумерный массив из целых чисел. Найдите среднее арифмметическое элементов
// в каждом столбце.
/*int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue+1);
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++ )
    {
        for(int j =0; j < array.GetLength(1); j++)
           Console.Write(array[i,j] + " ");

        Console.WriteLine();   
    }
}

Console.Write("Input f number of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(n,m,min,max);
Show2dArray(myArray);

void Arithmetik(int[,]myArray)
{ 
    for(int i = 0; i < myArray.GetLength(1); i++)
    {   
        double sum = 0;
        for(int j =0; j < myArray.GetLength(0); j++)
        {  
           sum = sum + myArray[j,i];
        
           Math.Round(sum,2);
        }
        Console.WriteLine($"Среднее арифметическое: " + sum / myArray.GetLength(0));                            
    }
    Console.WriteLine();
}

Arithmetik(myArray);*/