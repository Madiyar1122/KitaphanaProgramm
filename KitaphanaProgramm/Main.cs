using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitaphanaProgramm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void кітапБеруМекеніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.ActiveForm.Hide();
            GetBooks getBooks = new GetBooks();
            getBooks.Show();
        }

        private void редакторлауToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void кітаптарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.ActiveForm.Hide();
            Books books = new Books();
            books.Show();
        }

        private void қолданушыларToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.ActiveForm.Hide();
            Users users = new Users();
            users.Show();
        }

        private void кітаптарТізіміToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.ActiveForm.Hide();
            BooksList booksList = new BooksList();
            booksList.Show();
        }

        private void қолданушыларТізіміToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.ActiveForm.Hide();
            UsersList usersList = new UsersList();
            usersList.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main.ActiveForm.Hide();
            UsersList usersList = new UsersList();
            usersList.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main.ActiveForm.Hide();
            GetBooks getBooks = new GetBooks();
            getBooks.Show();
        }
    }
}
