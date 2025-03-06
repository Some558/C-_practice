namespace CS34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Counter c = new Counter();
            c.GetData(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Counter c = new Counter();
                c.GetData(1);
            }
            catch (ArgumentOutOfRangeException aex)
            {
                MessageBox.Show("AAA" + aex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ボタン2を押してエラー");
            }
        }
    }
}
