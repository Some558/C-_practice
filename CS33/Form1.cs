namespace CS33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Database product = new Product();
            Database order = new Order();

            List<Database> list = new List<Database>();
            list.Add(product);
            list.Add(order);

            foreach (Database db in list)
            {
                db.Save();
            }

        }
    }
}
