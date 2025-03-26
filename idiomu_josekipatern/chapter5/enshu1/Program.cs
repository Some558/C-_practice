public record YearMonth
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
        var yearmonth2 = new List<YearMonth>
        {
            new YearMonth(1234,10),
            new YearMonth(1235,6),
            new YearMonth(1834,7),
            new YearMonth(1237,8),
            new YearMonth(1238,9)
        };

        var first21Century = FindFirst21stCentury(yearmonth2);

        if (first21Century != null)
        {
            Console.WriteLine(first21Century.Year);
        }
        else
        {
            Console.WriteLine("21世紀のデータはありません");
        }

        var nextMonths = yearmonth2.Select(ym => ym.AddOneMonth()).ToList();

        foreach (var nextMonth in nextMonths)
        {
            Console.WriteLine(nextMonth);
        }
    }

    public static YearMonth FindFirst21stCentury(List<YearMonth> yearmonths)
    {
        foreach (var _yearmonth in yearmonths)
        {
            if (_yearmonth.Is21Century)
            {
                return _yearmonth;
            }
        }
        return null;
    }

    public static List<YearMonth> AddYearMonth(List<YearMonth> yearMonths)
    {
        var result = new List<YearMonth>();

        foreach (var yearMonth in yearMonths)
        {
            var nextMonth = yearMonth.AddOneMonth();
            result.Add(nextMonth);
        }
        return result;
    }

}