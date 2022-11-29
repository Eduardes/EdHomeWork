// Задача № 64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
//промежутке от N до 1, с помощью рекурсии.
/*
void ShowNumbers(int n)
{
    Console.Write(n + " ");
    if(n > 1) ShowNumbers(n-1);
}
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNumbers(n);
*/
//Задача № 66. Задать значение M и N. Напишите программу, которая найдет сумму натуральных элементов от M до N.

/**
    * m - параметрт от какого числа будет начинаться рекурсия =
    * n - параметр до какого числа будет заканчиваться рекурсия
*/
/*int SumElements(int m, int n)
{
    if(m < n)
    {   
        return m + SumElements(m+1,n);
    }
    return m;
}
Console.Write("Input a number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumElements(m,n));*/

//Задача № 68. Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два не отрицательных числа m и n.

/*int Akkirman(int m, int n)
{
    if( m==0)
       return n+1;
    else
       if(m !=0 && n==0)
          return Akkirman(m-1,1);
    else
        return Akkirman (m-1, Akkirman(m, n-1));
}
Console.Write("Input a number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Результат: " + Akkirman(m,n));
*/