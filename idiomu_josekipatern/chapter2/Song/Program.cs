namespace chapter2.Songman;

class Program
{
    static void Main()
    {
        var songs = new List<Song>
        {
            new Song("最後の晩餐", "レベッカ", 431),
            new Song("祭りだ", "吉川晃司", 43),
            new Song("恋のヴィーナス", "タキツバ", 124)
        };
        foreach(var time in songs)
        {
            int minitus = time.Length / 60;
            int seconds = time.Length % 60;
            Console.WriteLine($"演奏時間は、{minitus}:{seconds}");
        }

    }
}
