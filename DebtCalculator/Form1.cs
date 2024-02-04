using DebtCalculator.Models;

namespace DebtCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {      

            Database.InsertData(new Person("Yousif", "218", "Belsly", 120));
        }
    }
}
