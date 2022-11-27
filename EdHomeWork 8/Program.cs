// Задача №54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.

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

void SelectionSort(int[,] myArray)
{ 
    for(int i = 0; i < myArray.GetLength(0); i++)
       for(int max1 = 0; max1 < myArray.GetLength(1); max1++) 
        for(int j = 0; j < myArray.GetLength(1); j++)
            {   
                if(myArray[i,j] < myArray[i,max1])
                {
                   int temp = myArray[i,max1];
                   myArray[i,max1] = myArray[i,j];
                   myArray[i,j] = temp;
                }
             
            }   

}
Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
Console.WriteLine();
SelectionSort(myArray);
Show2dArray(myArray);*/

// Задача № 56. Здайте прямоугольный двумерный массив. напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
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

void MinSumElements(int[,] myArray)
{ 
    int[]arr = new int[myArray.GetLength(0)];

    for(int r = 0; r < myArray.GetLength(0); r++)
    {
        int sum = 0; 
        for(int j = 0; j < myArray.GetLength(1); j++)
        {
            sum += myArray[r, j];
        }
        arr[r] = sum;
    }
    int Min = arr[0];
    int Index = 0;
    for (int k = 0; k < arr.Length; k++)
    {
        if (Min > arr[k])
        {
            Min = arr[k];
            Index = k;
        }
    }
    for(int j = 0; j < myArray.GetLength(1); j++)
    {
        Console.Write(myArray[Index, j] + " ");
    }
}
Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
Console.WriteLine("Строка с наименьшей суммой:");
MinSumElements(myArray);*/

// Задача № 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array= new int[rows,columns];

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

int[,] CreateRandom2dArr(int rows1, int columns1, int minValue, int maxValue)
{
    int[,] arr= new int[rows1,columns1];

    for(int i = 0; i < rows1; i++)
        for(int j = 0; j < columns1; j++)

            arr[i,j] = new Random().Next(minValue, maxValue+1);
 
    return arr;
    
}

void Show2dArr(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++ )
    {
        for(int j =0; j < arr.GetLength(1); j++)
           Console.Write(arr[i,j] + " ");

        Console.WriteLine();   
    }
}

void ProductMatrices(int[,] myArray, int[,] myArr)
{
    if (myArray.GetLength(1) != myArr.GetLength(0))
    {
         Console.WriteLine("  Произведение невозможно");
        Console.WriteLine("Количество столбцов: " + myArray.GetLength(1));
        Console.WriteLine("Количество строк: " + myArr.GetLength(0));
        Console.WriteLine("Kоличество столбцов в первой матрице, должно быть равно количеству строк во второй");
        Console.WriteLine("Повторите ввод");
        return; 
    }    
    int[,] Result = new int[myArray.GetLength(0), myArr.GetLength(1)];
    for (int i = 0; i < myArray.GetLength(0); ++i)
    {
        for (int j = 0; j < myArr.GetLength(1); ++j)
        {
            Result[i,j] = 0;
            for (int k = 0; k < myArr.GetLength(0); ++k)
                Result[i,j] += myArray[i,k] * myArr[k,j];
        } 
    }
    Console.WriteLine();
    Show2dArr(Result);               
}  
Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of rows1: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns1: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minnum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxnum = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
Console.WriteLine();
int[,] myArr = CreateRandom2dArr(r,k,minnum,maxnum);
Show2dArr(myArr);
ProductMatrices(myArray, myArr);*/



// Задача № 62. Напишите программу, которая заполнит спирально массив. 

/*void Spiral(int rows, int columns)
{
    if (rows != columns)
    {
        Console.Write("Работает только с квадратными массивами");
        return;
    }
   int[,] myArray = new int[rows,columns];
   int k = 1;
    int i = 0;
    int j = 0;
    while (k <= rows*columns)
    {    
        myArray[i,j] = k;
        if (i <= j + 1 && i + j < rows - 1)
            j++;
        else if (i < j && i + j >= columns - 1)
            i++;
        else if (i >= j && i + j > columns - 1)
            j--;
        else 
            i--;
        k++;
    }
    
    for (int r = 0; r < myArray.GetLength(0); r++)
    {
        for (int c = 0; c < myArray.GetLength(1); c++)
        {
            if (myArray[r,c] >= 1 && myArray[r,c] <= 9)
            {
                Console.Write("0");
            }
            Console.Write(myArray[r,c] + " ");
        }   
        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Spiral(m, n);*/




