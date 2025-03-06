namespace CounterApp
{
    public partial class Form1 : Form
    {
        private int label = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label < 10)
            {
                label++;
                label1.Text = label.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label > -10)
            {
                label--;
                label1.Text = label.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
        }
    }
}
