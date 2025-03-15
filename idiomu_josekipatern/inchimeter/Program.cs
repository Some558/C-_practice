using DistanceConverter;

    inchiToMeterList(1,10);
    static void inchiToMeterList(int start, int stop)
    {
        for(int inchi = start; inchi <= stop; inchi++)
        {
            double meter = InchiConverter.inchiToMeter(inchi);
            Console.WriteLine($"{inchi} inchiは {meter}mです。");
        }
    }