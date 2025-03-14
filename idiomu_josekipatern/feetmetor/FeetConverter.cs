namespace DistanceConverter
{
    public static class FeetConverter
    {
        private const double ratio = 0.3048;
        public static double FeetToMeter(double feet)
        {
        return feet * ratio;
        }

        public static double MeterToFeet(double meter)
        {
        return meter / ratio;
        }
    }
}
    