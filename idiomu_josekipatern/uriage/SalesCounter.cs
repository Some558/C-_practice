namespace SalesCalculator;

public class SalesCounter{
    private readonly List<Sale> _sales;

    public SalesCounter(List<Sale> sales){
        _sales = sales;
    }

    public Dictionary<string, int> GetPerStoreSales()
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        // _salesにはSale型のオブジェクトが入っている
        foreach(Sale sale in _sales)
        {
            // dict内にShopNameが格納されているかチェック
            if(dict.ContainsKey(sale.ShopName))
                // 格納されている場合は、そこにAmountのみを追加する
                dict[sale.ShopName] += sale.Amount;
            else
                // 格納されていない場合は、shopnameとamountをセットで追加する
                dict[sale.ShopName] = sale.Amount;
        }
        // dictオブジェクトを返す
        return dict;
    }
}