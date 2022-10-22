// Задача 10. Напишите программу, которая принимает на входе трёхзначное число и на выходе показывает второю цифру.

/*int SecondDigit(int number)
{
    int figure = number / 10 % 10;
    return figure;
}
Console.Write("Трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SecondDigit(number);
Console.WriteLine($"Вторая цифра {result} ");
*/

// Задача 13. Напишите программу, которая выводит третью цифру заданого числа или сообщает, что третьей цифры нет.


/*void Figure(int number)
{
    if(number < 100)
    {
        Console.WriteLine("нет третьей цифры");
        return;
    }

    while(number >= 1000)
    {
        number = number / 10;

        if(number < 1000)
        {
            number = number % 10;
            Console.WriteLine(number);
            return;
        }
           
    }
}

Console.Write("Задать число: ");
int number = Convert.ToInt32(Console.ReadLine());
Figure(number);*/


/* Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет,
 является ли этот день выходным. */

 /* bool Week(int number)
 {
    if(number == 6)
    {
        return true;
    }
    if(number == 7)
    {
        return true;
    }
    else
    {
        return false;
    }

 }

 Console.Write("number: ");
 int number = Convert.ToInt32(Console.ReadLine());
 bool res = Week(number);
 Console.WriteLine(res);
*/
    

 




