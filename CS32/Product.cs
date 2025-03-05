using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS32
{
    // 継承と違い、Intaefaceは複数実装できる
    public class Product : IDatabase
    {
        public void Save()
        {
            Console.WriteLine("商品マスタの保存")
        }
    }


}
