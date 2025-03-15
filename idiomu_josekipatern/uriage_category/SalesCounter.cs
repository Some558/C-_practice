namespace SalesCalculator;

public class SalesCounter{
    private readonly IEnumerable<Sale> _sales;

    public SalesCounter(string filePath){
        _sales = ReadSales(filePath);
    }

    public IDictionary<string, int> GetPerStoreSales()
    {
        var dict = new Dictionary<string, int>();
        // _salesにはSale型のオブジェクトが入っている
        foreach(Sale sale in _sales)
        {
            // dict内にShopNameが格納されているかチェック
            if(dict.ContainsKey(sale.ProductCategory))
                // 格納されている場合は、そこにAmountのみを追加する
                dict[sale.ProductCategory] += sale.Amount;
            else
                // 格納されていない場合は、shopnameとamountをセットで追加する
                dict[sale.ProductCategory] = sale.Amount;
        }
        // dictオブジェクトを返す
        return dict;
    }

    private static IEnumerable<Sale> ReadSales(string filePath)
    {
    var sales = new List<Sale>();
    string[] lines = File.ReadAllLines(filePath);
    foreach(string line in lines)
    {
        string[] items = line.Split(',');
        var sale = new Sale
        {
            ShopName = items[0],
            ProductCategory = items[1],
            Amount = int.Parse(items[2])
        };
        sales.Add(sale);
    }
    return sales;
    }
}