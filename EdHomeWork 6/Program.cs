// Задача № 41. ввести М чисел. Посчитать, сколько чисел больше 0 ввёл пользователь.

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

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
int NumArray(int[] myArray)
{
   int count = 0;
   for(int i =0; i < myArray.Length; i++)  
      if(myArray[i] > 0)
         count++;
    return count;
}
Console.WriteLine(NumArray(myArray));*/

// Задача №43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениеми y = k1*x+b1,
// y = k2*x+b2. Значения b1,k1,b2,k2 задают пользователи.

/*Console.Write("Input a number b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

int x = (b2-b1)/(k1-k2);
int y = k1*(b2-b1)/(k1-k2)+b1;  
 
Console.WriteLine($"X:{x}  Y:{y}");
*/


