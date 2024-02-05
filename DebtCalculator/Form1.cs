using DebtCalculator.Models;
using System.Diagnostics;

namespace DebtCalculator
{
    public partial class Form1 : Form
    {
        private int ChosenId { get; set; }
        private string ChosenDate { get; set; }
        public Form1()
        {
            InitializeComponent();
            ChosenDate = DateTime.Now.ToString("dd-MM-yyyy");
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
            var person = new Person(InputName.Text,ChosenDate, Convert.ToInt32(InputBalance.Text), InputPhone.Text);
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
                var History = Database.GetHistories(search);
                HistoryData.DataSource = History;
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            InputSearch.Clear();
            InputName.Clear();
            InputPhone.Clear();
            InputBalance.Clear();
            RefreshData();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Database.Update(ChosenId, InputName.Text, InputPhone.Text, ChosenDate, Convert.ToInt32(InputBalance.Text));
            RefreshData();
        }

        private void InputDate_ValueChanged(object sender, EventArgs e)
        {
            
             // Get the selected date as a string with default format
                string selectedDateAsString = InputDate.Value.ToString();             
                // To format the date, for example as "Year-Month-Day"
                string formattedDate = InputDate.Value.ToString("dd-MM-yyyy");
                ChosenDate = formattedDate;
                 
        }
    }
}
