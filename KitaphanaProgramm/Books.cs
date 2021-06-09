using MySql.Data.MySqlClient;
using Sitecore.FakeDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace KitaphanaProgramm
{
    public partial class Books : Form
    {

        //private SqlConnection sqlConnection = null;

        private SqlConnection BooksDBConnection = null;


        public Books()
        {
            InitializeComponent();
            
        }

        private void қолданушыларТізіміToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books.ActiveForm.Hide();
            UsersList usersList = new UsersList();
            usersList.Show();
        }

        private void мәзірToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books.ActiveForm.Hide();
            Main main = new Main();
            main.Show();
        }

        private void қолданушыларToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books.ActiveForm.Hide();
            Users users = new Users();
            users.Show();
        }

        private void кітапБеруМекеніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books.ActiveForm.Hide();
            GetBooks getBooks = new GetBooks();
            getBooks.Show();
        }

        private void кітаптарТізіміToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books.ActiveForm.Hide();
            BooksList booksList = new BooksList();
            booksList.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            BooksDBConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["BooksDB"].ConnectionString);

            BooksDBConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Books",BooksDBConnection);

            DataSet db = new DataSet();

            dataAdapter.Fill(db);

            dataGridView1.DataSource = db.Tables[0];

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Name LIKE '%{textBox1.Text}%'";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex) 
            {
                case 0:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Janr LIKE'%{comboBox1.Text}%'";// string.Format("Field = '{0}'", textBoxFilter.Text);
                    break;
                case 1:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Janr LIKE'%{comboBox1.Text}%'";
                    break;
                case 2:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Janr LIKE'%{comboBox1.Text}%'";
                    break;
                case 3:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Janr LIKE '%{comboBox1.Text}%'";
                    break;
                case 4:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Janr LIKE '%{comboBox1.Text}%'";
                    break;
                case 5:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Janr LIKE '%{comboBox1.Text}%'";
                    break;
                case 6:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Janr LIKE '%{comboBox1.Text}%'";
                    break;
                case 7:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Janr LIKE '%{comboBox1.Text}%'";
                    break;
                case 8:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
                    break;
                    /*Детектив
                    Комедия
                    Кулинария
                    Триллер
                    Фантастика
                    Словарь
                    Боевик
                    Приключения*/
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Avtor LIKE '%{textBox2.Text}%'";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
