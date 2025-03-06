using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS34
{
    public sealed class CsvReadException : Exception
    {
        public CsvReadException(string message)
            :base("CSVの読み込みに失敗しました")
        {

        }
    }
}
