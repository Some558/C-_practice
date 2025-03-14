using DistanceConverter;

    // args.Lengthはコマンドライン引数の数　
    if(args.Length >= 1 && args[0] == "-tom")
    {
        PrintFeetToMeterList(1,10);
    }else
    {
        PrintMeterToFeetList(1,10);
    }

    static void PrintFeetToMeterList(int start, int stop)
    {
        for(int feet = start; feet <= stop; feet++)
        {
            double meter = FeetConverter.FeetToMeter(feet);
            Console.WriteLine($"{feet} feetは {meter}mです。");
        }
    }

    static void PrintMeterToFeetList(int start, int stop)
    {
        for(int meter = 0; meter <= stop; meter++)
        {
            double feet = FeetConverter.MeterToFeet(meter);
            Console.WriteLine($"{meter}meterは{feet}fです。");
        }
    }    