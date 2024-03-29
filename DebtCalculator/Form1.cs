using DebtCalculator.Models;
using System.Diagnostics;

namespace DebtCalculator
{
    public partial class Form1 : Form
    {
        private int ChosenId { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        private void RefreshData()
        {
            var people = Database.GetData();
            Data.DataSource = people;
            var History = Database.GetHistories();
            HistoryData.DataSource = History;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            var person = new Person(InputName.Text, InputAddress.Text, Convert.ToInt32(InputBalance.Text), InputPhone.Text);
            Database.InsertData(person);
            RefreshData();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Database.DeleteData(ChosenId, InputName.Text);
            RefreshData();
        }

        private void Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Data.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    Data.CurrentRow.Selected = true;
                    ChosenId = Convert.ToInt32(Data.Rows[e.RowIndex].Cells["Id"].FormattedValue);
                    InputName.Text = Data.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                    InputAddress.Text = Data.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                    InputPhone.Text = Data.Rows[e.RowIndex].Cells["Phone"].FormattedValue.ToString();
                    InputBalance.Text = Data.Rows[e.RowIndex].Cells["Balance"].FormattedValue.ToString();
                    var History = Database.GetHistories(InputName.Text);
                    HistoryData.DataSource = History;
                }
            }
            catch
            {
                Console.WriteLine("Unknown Header");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string search = InputSearch.Text;
            if (!string.IsNullOrEmpty(search))
            {
                var person = Database.Search(search);
                Data.DataSource = person;
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            InputSearch.Clear();
            InputName.Clear();
            InputAddress.Clear();
            InputPhone.Clear();
            InputBalance.Clear();
            RefreshData();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Database.Update(ChosenId, InputName.Text, InputPhone.Text, InputAddress.Text, Convert.ToInt32(InputBalance.Text));
            RefreshData();
        }
    }
}
