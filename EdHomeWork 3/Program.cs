/* Задача 19. Напишите программу, которая на входе принимает пятизначное число и проверяет,
 является ли это число полиндромом. */

 /* bool Palindrome(int number)
 {
    int n1 = number % 10;
    int n2 = number / 10000;
    int n3 = number /10 % 10;
    int n4 = number /1000 % 10;

    if(n1 == n2 & n3 == n4)
    {
         return true;
    }
    else
    {
        
        return false;
    }

 }

 Console.Write("Ввести пятизначное число: ");
 int num = Convert.ToInt32(Console.ReadLine());
 bool res = Palindrome(num);
 Console.WriteLine(res);
*/

/* Задача 21. Напишите программу, которая принимает на входе координаты двух точек 
и находит расстояние между ними в 3D пространстве.*/

/*int ShowDistanse(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int a = x2 - x1;
    int b = y2 -y1;
    int c = z2 - z1;
    int d = a * a + b * b + c * c;
    Math.Sqrt(d);
    return d;
}
Console.Write("Введите координаты X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
int res = ShowDistanse(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками {res}");
*/

// Задача 23. Напишите программу, которая на входе принимает число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*int CalculateKube(int number)
{
    return number*number*number;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i <= number)
{
    int Result = CalculateKube(i);
    Console.Write(Result + " ");
    i++;
}*/

