public class YearMonth
{
    public int Year { get; }
    public int Month { get; }

    public YearMonth(int year, int month)
    {
        Year = year;
        Month = month;
    }

    public bool Is21Century => Year >= 2001 && Year <= 2100;

    public YearMonth AddOneMonth()
    {
        if (Month == 12)
        {
            return new YearMonth(Year + 1, 1);
        }
        else
        {
            return new YearMonth(Year, Month + 1);
        }
    }

    public override string ToString()
    {
        return $"{Year}年{Month}月";
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        var yearmonth = new YearMonth(2010, 11);
        Console.WriteLine(yearmonth.ToString()); // 出力: 2010年11月

        var nextMonth = yearmonth.AddOneMonth();
        Console.WriteLine(nextMonth.ToString()); // 出力: 2010年12月

        Console.WriteLine($"Is 21st Century: {yearmonth.Is21Century}"); // 出力: Is 21st Century: True

        var yearmonth2 = new List<YearMonth>
        {
            new yearmonth2(1234,10),
            new yearmonth2(1235,6),
            new yearmonth2(1236,7),
            new yearmonth2(1237,8),
            new yearmonth2(1238,9)
        };
        yearmonth2.ForEach(n => Console.WriteLine($"[{n}]"));
    }
}