 // Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число больше, а какое меньше.

Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if(n1 > n2)
{
    Console.WriteLine($"number {n1} more number {n2} ");
}
else
{
    Console.WriteLine($"number {n1} less number {n2} ");
} 

// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if(n2 > max) max = n2;
if(n3 > max) max = n3;

Console.WriteLine($"Самое большое число {max}" );


// Задача 6. Напишите программу. которая на вход принимает число и выдаёт, является ли число чётным (делится на два).

Console.Write("Input a integer number: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n % 2 ==0)
{
    Console.WriteLine($"Число {n} является чётным ");
}
else
{
    Console.WriteLine($"Чиcло {n} является нечётным");
} 

 // Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input a namber ");
int n = Convert.ToInt32(Console.ReadLine());

int current = 1;
while(current <=n)
{
    if(current % 2 == 0)
    {
         Console.WriteLine($"Чётные числа {current}");

    }     
    current++;
} 