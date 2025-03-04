## static 静的メンバ
アプリにただ一つ定義したいときに使うもの
インスタンスのように複数作る必要がないもの

### メンバに使う場合
private static int _count = 0;
### メソッドに使う場合
internal static void Call();

## 例文

// 呼び出されるクラス側
    internal class Counter
    {
        // アプリケーションに一つだけ以下を持たせたい場合はstaticにする
        private static int _count = 0;
        // _valueはstaticではないからインスタンス化できる
        private int _value = 0;
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
        internal void DDD()
        {
            _value++;
        }
    }

// 呼び出し側
        public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var f = new Form2())
            {
                f.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var f = new Form3())
            {
                f.ShowDialog();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Counter c = new Counter();
            c.DDD();
            this.Text = Counter.GetCount().ToString();
        }
    }