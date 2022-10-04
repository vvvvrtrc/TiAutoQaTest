// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Enter coordinate x for dot A:");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nEnter coordinate y for dot A:");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nEnter coordinate x for dot B:");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nEnter coordinate y for dot B:");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nEnter coordinate x for dot C:");
int xC = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nEnter coordinate y for dot C:");
int yC = Convert.ToInt32(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow((xA - xB), 2) + Math.Pow((yA - yB), 2));
Console.WriteLine("The length of AB is: {0}", AB);
double BC = Math.Sqrt(Math.Pow((xB - xC), 2) + Math.Pow((yB - yC), 2));
Console.WriteLine("The length of BC is: {0}", BC);
double CA = Math.Sqrt(Math.Pow((xC - xA), 2) + Math.Pow((yC - yA), 2));
Console.WriteLine("The length of CA is: {0}", CA);

if (AB == BC && BC == CA)
    Console.WriteLine("It is the equilateral triangle");
if (AB == BC || BC == CA || CA == AB)
    Console.WriteLine("It is the isosceles triangle");
if ((Math.Pow(AB, 2) + Math.Pow(CA, 2)) == Math.Pow(BC, 2))
    Console.WriteLine("It is the right triangle");

double PerimeterOfTriangle = AB + BC + CA; 
Console.WriteLine("Perimeter of triangle is:{0}", PerimeterOfTriangle);
for (int i = 0; i <= PerimeterOfTriangle; i++)
{
    if ((i % 2) != 0)
        continue;
    Console.WriteLine(i);
}
    Console.ReadKey();
