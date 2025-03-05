namespace CS32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            IDatabase product = new Product();
            IDatabase order = new Order();

            List<IDatabase> list = new List<IDatabase>();
            list.Add(product);
            list.Add(order);

            foreach (IDatabase db in list)
            {
                db.Save();
            }

        }
    }
}
