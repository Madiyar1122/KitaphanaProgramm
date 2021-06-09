using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace KitaphanaProgramm
{
    public partial class UsersList : Form
    {

        private SqlConnection BooksDBConnection = null;

        public UsersList()
        {
            InitializeComponent();
        }

        private void UsersList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDBDataSet1.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.booksDBDataSet1.Users);
            BooksDBConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["BooksDB"].ConnectionString);

            BooksDBConnection.Open();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlstm = "SELECT * FROM Users";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlstm, BooksDBConnection);
            DataSet DS = new System.Data.DataSet();
            adapter.Fill(DS, "Users");
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(

                $"DELETE [Users] WHERE UsersID = {textBox1.Text}",
                BooksDBConnection);

            command.Parameters.AddWithValue("UsersID", textBox1.Text);

            MessageBox.Show(command.ExecuteNonQuery().ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsersListAdd usersListAdd = new UsersListAdd();
            usersListAdd.Show();
        }
    }
}
