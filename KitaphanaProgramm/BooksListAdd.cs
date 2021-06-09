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
    public partial class BooksListAdd : Form
    {
        private SqlConnection BooksDBConnection = null;


        public BooksListAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(

                $"INSERT INTO [Books] (Name,Janr,Avtor,Year,Articul,Price) VALUES (@Name,@Janr,@Avtor,@Year,@Articul,@Price)",
                BooksDBConnection);

            command.Parameters.AddWithValue("Name", textBox1.Text);
            command.Parameters.AddWithValue("Janr", comboBox1.Text);
            command.Parameters.AddWithValue("Avtor", textBox3.Text);
            command.Parameters.AddWithValue("Year", textBox4.Text);
            command.Parameters.AddWithValue("Articul", textBox5.Text);
            command.Parameters.AddWithValue("Price", textBox6.Text);

            MessageBox.Show(command.ExecuteNonQuery().ToString());


            textBox1.Text = "";
            comboBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";


        }

        private void BooksListAdd_Load(object sender, EventArgs e)
        {
            BooksDBConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["BooksDB"].ConnectionString);

            BooksDBConnection.Open();

            if(BooksDBConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Қосылу орнатылды!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BooksListAdd.ActiveForm.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
