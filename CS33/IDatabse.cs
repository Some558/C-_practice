using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS32
{
    public abstract class Database
    {
        // アクセス修飾子はつけない
        public void Save()
        {
            Before();

            Execute();

            After();
        }

        protected abstract void Execute();

        private void Before()
        {

        }

        private void After()
        {

        }
    }
}
