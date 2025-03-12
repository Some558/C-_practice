using System;

for(int feet = 1; feet <=10; feet++)
{
    double meter = feet * 0.3048;
    Console.WriteLine($"{feet}ft = {meter:0.0000}m");
}