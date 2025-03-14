namespace SalesCalculator;

public class Sale{
    // nullを許可しないためstring.Emptyとしている。
    public string ShopName{get;set;} = string.Empty;

    public string ProductCategory{get;set;} = string.Empty;

    public int Amount{get;set;}
}

