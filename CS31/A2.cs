using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS30
{
    class A2:A1
    {
        public A2() : base(10)
        {
            base.ProtectedValue = 3;
        }

        public override int GetData()
        {
            var value = base.GetData();
            value += 3;
            return 333;
        }   
    }
}
