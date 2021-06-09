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
    public partial class UsersListAdd : Form
    {
        private SqlConnection BooksDBConnection = null;
        public UsersListAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(

                $"INSERT INTO [Users] (IIN,Name,Surname,Number,Adress) VALUES (@IIN,@Name,@Surname,@Number,@Adress)",
                BooksDBConnection);

            command.Parameters.AddWithValue("IIN", textBox1.Text);
            command.Parameters.AddWithValue("Name", textBox2.Text);
            command.Parameters.AddWithValue("Surname", textBox3.Text);
            command.Parameters.AddWithValue("Number", textBox4.Text);
            command.Parameters.AddWithValue("Adress", textBox5.Text);

            MessageBox.Show(command.ExecuteNonQuery().ToString());


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsersListAdd.ActiveForm.Hide();
        }

        private void UsersListAdd_Load(object sender, EventArgs e)
        {
            BooksDBConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["BooksDB"].ConnectionString);

            BooksDBConnection.Open();

            if (BooksDBConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Қосылу орнатылды!");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
