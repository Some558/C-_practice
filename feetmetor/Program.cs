using System;

if(args.Length >= 1 && args[0] == "-tom")
{

for(int feet = 1; feet <=10; feet++)
{
    double meter = FeetToMeter(feet);
    Console.WriteLine($"{feet}ft = {meter:0.0000}m");
}
}else
{
    for(int meter = 1;meter <= 10; meter++)
    {
        double feet = MeterToFeet(meter);
        Console.WriteLine($"{meter}m = {feet:0.0000}ft");
    }
}
    static double FeetToMeter(int feet)
    {
    return feet * 0.3048;
    }

    static double MeterToFeet(int meter)
    {
        return meter / 0.3048;
    }
    