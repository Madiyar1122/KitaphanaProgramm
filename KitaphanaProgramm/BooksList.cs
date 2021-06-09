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
    public partial class BooksList : Form
    {
        private SqlConnection BooksDBConnection = null;

        //SqlDataAdapter adapter;

        public BooksList()
        {
            InitializeComponent();
        }

        private void BooksList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDBDataSet.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.booksDBDataSet.Books);
            BooksDBConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["BooksDB"].ConnectionString);

            BooksDBConnection.Open();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BooksListAdd  booksListAdd = new BooksListAdd();
            booksListAdd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(

                $"DELETE [Books] WHERE BooksID = {textBox1.Text}",
                BooksDBConnection);

            command.Parameters.AddWithValue("BooksID", textBox1.Text);

            MessageBox.Show(command.ExecuteNonQuery().ToString());

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlstm = "SELECT * FROM Books";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlstm, BooksDBConnection);
            DataSet DS = new System.Data.DataSet();
            adapter.Fill(DS, "Books");
            dataGridView1.DataSource = DS.Tables[0];
        }
    }
}
