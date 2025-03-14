using chapter2.Songman;


class Song
{
    // プロパティ宣言時、フィールド宣言もいるんだっけ？
    public string Title{get; set;}
    public string ArtistName{get; set;}
    public int Length{get; set;}
    public Song(string title,string artistName, int length)
    {
        Title = title;
        ArtistName = artistName;
        Length = length;
    }
}
