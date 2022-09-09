/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0
 ввёл пользователь.
5
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
вариация задачи 41 - пользователь не задает сколько чисел он введет (то есть число M),
 а подсчет количества чисел производится после того, как пользователь не ввел информацию и нажал Enter.

int SumPositiv()
{
Console.WriteLine("Please input a numbers");
int [] Array = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
int Sum = 0;
for (int i = 0; i < Array.Length; i++)
{   
    if (Array[i] > 0) Sum += 1;
}
return Sum;
}

try 
{
   Console.WriteLine (SumPositiv());
}
catch
{
    Console.WriteLine ("Please input numbers separated by one space!");
}
*/
/********************************************************************************************************************************************************************************
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
  значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void Coordinates()
{
    Console.WriteLine("Please input numer b1");
    double b1 = Convert.ToDouble(Console.ReadLine()); 
    Console.WriteLine("Please input numer k1");
    double k1 = Convert.ToDouble(Console.ReadLine()); 
    Console.WriteLine("Please input numer b2");
    double b2 = Convert.ToDouble(Console.ReadLine()); 
    Console.WriteLine("Please input numer k2");
    double k2 = Convert.ToDouble(Console.ReadLine()); 

    for (double x = -10.5; x <= 10.5; x++)
        {
            for (double y = -10.5; y <= 10.5; y++)
            {
                if ( y == k1 * x + b1 && y ==k2 * x + b2 )
                    Console.WriteLine($"Intersecton point X({x}, Y{y})");
            }
        }
}
try
{
   Coordinates(); 
}
catch
{
Console.WriteLine("Please input correctly");
}
*/
/* *******************************************************************************************************************************************************************************
задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа.
 Определить , является ли это сторонами треугольника. Если да, то вывести всю информацию 
 по нему - площадь, периметр, значения углов треугольника в градусах, является ли он 
 прямоугольным, равнобедренным, равносторонним.

void TriangelPar()
{
    Console.WriteLine("Please input side a of the triangle");
    double a = Convert.ToDouble(Console.ReadLine()); 
    Console.WriteLine("Please input side b of the triangle");
    double b = Convert.ToDouble(Console.ReadLine()); 
    Console.WriteLine("Please input side c of the triangle");
    double c = Convert.ToDouble(Console.ReadLine()); 
    
    if (a + b > c && a + c > b && b +c > a )
    {
        Console.WriteLine("This is triangle");
        double p = ( a + b + c ) / 2; // полупериметр
        double S = Math.Sqrt(p *(p - a) * (p - b) * (p - c));
        double P = p *2; //периметр

        if (a*a == c*c + b*b || b*b == a*a + c*c || c*c == a*a + b*b) Console.WriteLine("This is right triangle ");
        if ((a == b && a != c) || (a == c && a != b ) || (b == c && b != c)) Console.WriteLine("This is isosceles triangle");
        if (a == b && a == c) Console.WriteLine("This is equilateral triangle");

        Console.WriteLine($"S = {S}, P = {P}, ");
        Console.WriteLine ("Angles of triangle: ");
        Console.WriteLine("{0:F3}", Math.Acos((b*b + c*c - a*a) / (2*b*c)) * 180 / Math. PI);
        Console.WriteLine("{0:F3}", Math.Acos((a*a + c*c - b*b) / (2*a*c)) * 180 / Math. PI);
        Console.WriteLine("{0:F3}", Math.Acos((a*a + b*b - c*c) / (2*a*b)) * 180 / Math. PI);
    } 
    else Console.WriteLine("This is not a triangle");
}
try
{
   TriangelPar(); 
}
catch
{
Console.WriteLine("Please input correctly");
}
*/