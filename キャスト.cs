## double型の結果をint型にキャストする例
public interface GetTax()
{
    return (int) (Price* _taxRate);
}


var numbers = baseValue.Split(' ').Select(int.Parse).ToArray();