
//  Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue);
    return array;
}
void ShowArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();     
}
int FindElement(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
         if(array[i]% 2 == 0)
             count++;
     return count;        
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
Console.WriteLine(FindElement(myArray));*/

// Задача 36. Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue +1);
    return array;
}
void ShowArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();     
}

int FindElementSum(int[]array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(i % 2 !=0)
            sum += array[i];
    return sum;        
}
Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
Console.WriteLine(FindElementSum(myArray));*/

//Задача 38. Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

/*int[] CreateRandomArray(int size, int minValue, int maxValue)
{
int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue +1);
    return array;
}
void ShowArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();     
}
int GetPosMax(int[]array)
{
    int max = array[0];
    for(int i = 0; i < array.Length; i++)
        if(array[i] > max)  
           max = array[i];   
        return max;  
}
int GetPosMin(int[]array)
{
    int min = array[0];
    for(int i = 0; i < array.Length; i++)
        if(array[i] < min)  
           min = array[i];   
        return min;  
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
int ma = GetPosMax(myArray);
int mi = GetPosMin(myArray);
int deff = ma - mi;

Console.WriteLine(deff);*/