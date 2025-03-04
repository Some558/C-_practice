namespace CS29
{
    internal class Counter
    {
        // アプリケーションに一つだけ以下を持たせたい場合はstaticにする
        private static int _count = 0;
        // 静的メソッド
        internal static void Call()
        {
            _count++;
            // _value = 1;

            // var ddd = 0;
            // ddd = 1;
        }

        internal static int GetCount()
        {
            return _count;
        }
    }
}
