﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
/*
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Доброго времени суток, дорогой друг))");
System.Console.WriteLine("Программа сравнит 2 числа");

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
    {
        Console.WriteLine($"Число {num1} больше чем {num2}");
    }
else if (num1 < num2)
        {
            Console.WriteLine($"Число {num2}, больше чем {num1}");
        }
    else Console.WriteLine($"Числа равны");

Console.ReadKey();
Console.Clear();
*/
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

System.Console.WriteLine("Программа выводит максимальное из трёх чисел");
Console.WriteLine("Введите три числа!");

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max;
if (number1 > number2)
    {
        max = number1;
    }
else max = number2;

if (max < number3)
    {
        max = number3;
    }
 
Console.WriteLine($"Максимальное число будет: {max}");

Console.ReadKey();
Console.Clear();

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
/*
Console.WriteLine("Программа проверит число на чётность");
System.Console.Write("Введите любое число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 > 0)
    {
        Console.WriteLine("Это нечётное число");
    }
else Console.WriteLine("Это чётное число");

Console.ReadKey();
Console.Clear();
*/
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает 
//все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
/*
System.Console.WriteLine("Программа выводит все чётные числа от 1 до N");
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int count = 1;

while(count <= numberN)
    {
        if(count % 2 == 0)
            {
                Console.Write(count + " ");
            }
        count++;
    }

Console.ReadKey();
Console.Clear();
*/