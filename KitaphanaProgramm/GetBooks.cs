using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Runtime.InteropServices;

namespace KitaphanaProgramm
{

    public partial class GetBooks : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        private SqlConnection BooksDBConnection = null;
        public GetBooks()
        {
            InitializeComponent();

            PnlNav.Height = btnGet.Height;
            PnlNav.Top = btnGet.Top;
            PnlNav.Left = btnGet.Left;
            btnGet.BackColor = Color.Gray;
            
        }

        private void мәзірToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetBooks.ActiveForm.Hide();
            Main main = new Main();
            main.Show();
        }

        private void кітаптарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetBooks.ActiveForm.Hide();
            Books books = new Books();
            books.Show();
        }

        private void қолданушыларToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetBooks.ActiveForm.Hide();
            Users users = new Users();
            users.Show();
        }

        private void кітаптарТізіміToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetBooks.ActiveForm.Hide();
            BooksList booksList = new BooksList();
            booksList.Show();
        }

        private void қолданушыларТізіміToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetBooks.ActiveForm.Hide();
            UsersList usersList = new UsersList();
            usersList.Show();
        }

        private void GetBooks_Load(object sender, EventArgs e)
        {

            BooksDBConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["BooksDB"].ConnectionString);

            BooksDBConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM GetBooks", BooksDBConnection);

            DataSet db = new DataSet();

            dataAdapter.Fill(db);

            dataGridView1.DataSource = db.Tables[0];
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            btnPass.BackColor = Color.FromArgb(38, 54, 192);
            btnGet.BackColor = Color.FromArgb(38, 54, 192);
            PnlNav.Height = btnFilter.Height;
            PnlNav.Top = btnFilter.Top;
            btnFilter.BackColor = Color.LightGray;
         

            pnlGet.Visible = false;
            pnlPass.Visible = false;
            pnlFilter.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            btnPass.BackColor = Color.FromArgb(38, 54, 192);
            btnFilter.BackColor = Color.FromArgb(38, 54, 192);
            PnlNav.Height = btnGet.Height;
            PnlNav.Top = btnGet.Top;
            PnlNav.Left = btnGet.Left;
            btnGet.BackColor = Color.Gray;

            pnlGet.Visible = true;
            pnlPass.Visible = false;
            pnlFilter.Visible = false;

        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            btnGet.BackColor = Color.FromArgb(38, 54, 192);
            btnFilter.BackColor = Color.FromArgb(38, 54, 192);
            PnlNav.Height = btnPass.Height;
            PnlNav.Top = btnPass.Top;
            btnPass.BackColor = Color.Gray;

            pnlGet.Visible = false;
            pnlPass.Visible = true;
            pnlFilter.Visible = false;
        }

        private void btnFilter_Leave(object sender, EventArgs e)
        {
            btnFilter.BackColor = Color.LightGray;
        }

        private void btnPass_Leave(object sender, EventArgs e)
        {
            btnPass.BackColor = Color.Gray;
        }

        private void btnGet_Leave(object sender, EventArgs e)
        {
            btnGet.BackColor = Color.Gray;
        }
    }
}
