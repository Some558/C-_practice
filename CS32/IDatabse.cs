using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS32
{
    public interface IDatabase
    {
        // アクセス修飾子はつけない
        void Save();
    }
}
