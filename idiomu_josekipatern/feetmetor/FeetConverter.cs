using System;

namespace DistanceConverter
{
    public static class FeetConverter
    private const double ratio = 0.3048;
    {
        public static double FeetToMeter(int feet)
        {
        return feet * ratio
        }

        public static double MeterToFeet(int meter)
        {
        return meter / ratio;
        }
    }
}