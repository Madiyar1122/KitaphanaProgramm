using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitaphanaProgramm
{
    public partial class Users : Form
    {
        private SqlConnection BooksDBConnection = null;

        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDBDataSet1.Users". При необходимости она может быть перемещена или удалена.
           // this.usersTableAdapter.Fill(this.booksDBDataSet1.Users);
            BooksDBConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["BooksDB"].ConnectionString);

            BooksDBConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Users", BooksDBConnection);

            DataSet db = new DataSet();

            dataAdapter.Fill(db);

            usersDataGridView.DataSource = db.Tables[0];

        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booksDBDataSet1);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            (usersDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"IIN LIKE '%{textBox1.Text}%'";

        }

        private void мәзірToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users.ActiveForm.Hide();
            Main main = new Main();
            main.Show();
        }

        private void кітаптарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users.ActiveForm.Hide();
            Books books = new Books();
            books.Show();
        }

        private void қолданушыларToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
