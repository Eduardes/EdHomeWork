// Задача 25. Напишите цикл, который на вход принимает два числа (А и В) и выводить число А в натуральную степень В.

/*int Digree(int a, int b)
{
    int dig = 1;
    int current = 1;
    while(current <=b)
    {
        dig = dig*a;       
        current++;
    }
    return dig;
}
Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int b = Convert.ToInt32(Console.ReadLine());
int res = Digree(a,b);
Console.WriteLine($"Число А в степени В {res}");*/

// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*int Find(int num)
{
    int sum = 0;

    while(num != 0)
    {                  
        sum= sum + num % 10;
        num = num /10;
             
    }                               
    return sum;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр:{Find(num)}");*/

//Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*
void FillArray(int[] numbers)

{
   int index = 0;
   int length = numbers.Length;
   while(index < length)
   {
       numbers[index] =  new Random().Next(1, 8);
       index++;
   }
 
}

void PrintArray(int[] num)
{
    int count = num.Length;
    int i = 0;
    while(i < count)
    {
        Console.Write(num[i]);
        i++;
    }
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);
*/