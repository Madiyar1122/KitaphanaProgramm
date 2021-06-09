
namespace KitaphanaProgramm
{
    partial class Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.мәзірToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кітаптарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.қолданушыларToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кітапБеруМекеніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редакторлауToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кітаптарТізіміToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.қолданушыларТізіміToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.booksDBDataSet1 = new KitaphanaProgramm.BooksDBDataSet1();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new KitaphanaProgramm.BooksDBDataSet1TableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new KitaphanaProgramm.BooksDBDataSet1TableAdapters.TableAdapterManager();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.мәзірToolStripMenuItem,
            this.кітаптарToolStripMenuItem,
            this.қолданушыларToolStripMenuItem,
            this.кітапБеруМекеніToolStripMenuItem,
            this.редакторлауToolStripMenuItem,
            this.отчетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // мәзірToolStripMenuItem
            // 
            this.мәзірToolStripMenuItem.Name = "мәзірToolStripMenuItem";
            this.мәзірToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.мәзірToolStripMenuItem.Text = "Мәзір";
            this.мәзірToolStripMenuItem.Click += new System.EventHandler(this.мәзірToolStripMenuItem_Click);
            // 
            // кітаптарToolStripMenuItem
            // 
            this.кітаптарToolStripMenuItem.Name = "кітаптарToolStripMenuItem";
            this.кітаптарToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.кітаптарToolStripMenuItem.Text = "Кітаптар";
            this.кітаптарToolStripMenuItem.Click += new System.EventHandler(this.кітаптарToolStripMenuItem_Click);
            // 
            // қолданушыларToolStripMenuItem
            // 
            this.қолданушыларToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.қолданушыларToolStripMenuItem.Name = "қолданушыларToolStripMenuItem";
            this.қолданушыларToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.қолданушыларToolStripMenuItem.Text = "Оқырмандар";
            this.қолданушыларToolStripMenuItem.Click += new System.EventHandler(this.қолданушыларToolStripMenuItem_Click);
            // 
            // кітапБеруМекеніToolStripMenuItem
            // 
            this.кітапБеруМекеніToolStripMenuItem.Name = "кітапБеруМекеніToolStripMenuItem";
            this.кітапБеруМекеніToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.кітапБеруМекеніToolStripMenuItem.Text = "Кітап беру мекені";
            // 
            // редакторлауToolStripMenuItem
            // 
            this.редакторлауToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кітаптарТізіміToolStripMenuItem,
            this.қолданушыларТізіміToolStripMenuItem});
            this.редакторлауToolStripMenuItem.Name = "редакторлауToolStripMenuItem";
            this.редакторлауToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.редакторлауToolStripMenuItem.Text = "Редакторлау";
            // 
            // кітаптарТізіміToolStripMenuItem
            // 
            this.кітаптарТізіміToolStripMenuItem.Name = "кітаптарТізіміToolStripMenuItem";
            this.кітаптарТізіміToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.кітаптарТізіміToolStripMenuItem.Text = "Кітаптар тізімі";
            // 
            // қолданушыларТізіміToolStripMenuItem
            // 
            this.қолданушыларТізіміToolStripMenuItem.Name = "қолданушыларТізіміToolStripMenuItem";
            this.қолданушыларТізіміToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.қолданушыларТізіміToolStripMenuItem.Text = "Оқырмандар тізімі";
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.отчетToolStripMenuItem.Text = "Есептер";
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersDataGridView.Location = new System.Drawing.Point(0, 28);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.RowHeadersWidth = 51;
            this.usersDataGridView.RowTemplate.Height = 24;
            this.usersDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.usersDataGridView.Size = new System.Drawing.Size(921, 256);
            this.usersDataGridView.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 323);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Оқырманның ИИН-ны";
            // 
            // booksDBDataSet1
            // 
            this.booksDBDataSet1.DataSetName = "BooksDBDataSet1";
            this.booksDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.booksDBDataSet1;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = null;
            this.tableAdapterManager.GetBooksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KitaphanaProgramm.BooksDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(921, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.usersDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Users";
            this.Text = "Оқырмандар";
            this.Load += new System.EventHandler(this.Users_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem мәзірToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кітаптарToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem қолданушыларToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кітапБеруМекеніToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редакторлауToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кітаптарТізіміToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem қолданушыларТізіміToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private BooksDBDataSet1 booksDBDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private BooksDBDataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private BooksDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}