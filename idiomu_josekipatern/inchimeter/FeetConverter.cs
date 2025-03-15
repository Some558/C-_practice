namespace DistanceConverter
{
    public static class InchiConverter
    {
        private const double ratio = 0.0254;
        public static double inchiToMeter(double inchi)
        {
        return inchi * ratio;
        }
    }
}
    