using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS30
{
    class A1
    {
        private int _privateValue;
        protected int ProtectedValue;

        public A1(int value)
        {
            _privateValue = value;
        }

        // 以下で書き換えても書き換えなくてもよい
        public virtual int GetData()
        {
            return 100;

        }

    }
}
