using System;


    
Console.WriteLine("Calculating a length of the rectangle's diagonal,");
Console.WriteLine("insert side A:");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("insert side B:");
double b = double.Parse(Console.ReadLine());

Console.WriteLine($"The diagonal's length is equal to: {diag_calc(a,b)}");


static double diag_calc(double a, double b)
{
    return (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
}