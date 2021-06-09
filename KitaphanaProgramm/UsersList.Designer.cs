
namespace KitaphanaProgramm
{
    partial class UsersList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.мәзірToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кітаптарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.қолданушыларToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кітапБеруМекеніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редакторлауToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кітаптарТізіміToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.қолданушыларТізіміToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksDBDataSet1 = new KitaphanaProgramm.BooksDBDataSet1();
            this.usersTableAdapter = new KitaphanaProgramm.BooksDBDataSet1TableAdapters.UsersTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1156, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // мәзірToolStripMenuItem
            // 
            this.мәзірToolStripMenuItem.Name = "мәзірToolStripMenuItem";
            this.мәзірToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.мәзірToolStripMenuItem.Text = "Мәзір";
            // 
            // кітаптарToolStripMenuItem
            // 
            this.кітаптарToolStripMenuItem.Name = "кітаптарToolStripMenuItem";
            this.кітаптарToolStripMenuItem.Size = new System.Drawing.Size(82, 26);
            this.кітаптарToolStripMenuItem.Text = "Кітаптар";
            // 
            // қолданушыларToolStripMenuItem
            // 
            this.қолданушыларToolStripMenuItem.Name = "қолданушыларToolStripMenuItem";
            this.қолданушыларToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.қолданушыларToolStripMenuItem.Text = "Оқырмандар";
            // 
            // кітапБеруМекеніToolStripMenuItem
            // 
            this.кітапБеруМекеніToolStripMenuItem.Name = "кітапБеруМекеніToolStripMenuItem";
            this.кітапБеруМекеніToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.кітапБеруМекеніToolStripMenuItem.Text = "Кітап беру мекені";
            // 
            // редакторлауToolStripMenuItem
            // 
            this.редакторлауToolStripMenuItem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.редакторлауToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кітаптарТізіміToolStripMenuItem,
            this.қолданушыларТізіміToolStripMenuItem});
            this.редакторлауToolStripMenuItem.Name = "редакторлауToolStripMenuItem";
            this.редакторлауToolStripMenuItem.Size = new System.Drawing.Size(109, 26);
            this.редакторлауToolStripMenuItem.Text = "Редакторлау";
            // 
            // кітаптарТізіміToolStripMenuItem
            // 
            this.кітаптарТізіміToolStripMenuItem.Name = "кітаптарТізіміToolStripMenuItem";
            this.кітаптарТізіміToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.кітаптарТізіміToolStripMenuItem.Text = "Кітаптар тізімі";
            // 
            // қолданушыларТізіміToolStripMenuItem
            // 
            this.қолданушыларТізіміToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.қолданушыларТізіміToolStripMenuItem.Name = "қолданушыларТізіміToolStripMenuItem";
            this.қолданушыларТізіміToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.қолданушыларТізіміToolStripMenuItem.Text = "Қолданушылар тізімі";
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(78, 26);
            this.отчетToolStripMenuItem.Text = "Есептер";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(427, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 45);
            this.button3.TabIndex = 13;
            this.button3.Text = "Ref";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(780, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Оқырманның Id санын енгізініз";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(1086, 346);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 30);
            this.textBox1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(910, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 43);
            this.button2.TabIndex = 10;
            this.button2.Text = "Оқырманды жою";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(9, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Жаңа оқырманды қосу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usersIDDataGridViewTextBoxColumn,
            this.iINDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1156, 277);
            this.dataGridView1.TabIndex = 8;
            // 
            // usersIDDataGridViewTextBoxColumn
            // 
            this.usersIDDataGridViewTextBoxColumn.DataPropertyName = "UsersID";
            this.usersIDDataGridViewTextBoxColumn.FillWeight = 40F;
            this.usersIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.usersIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usersIDDataGridViewTextBoxColumn.Name = "usersIDDataGridViewTextBoxColumn";
            this.usersIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.usersIDDataGridViewTextBoxColumn.ToolTipText = "Оқырманның ID саны";
            // 
            // iINDataGridViewTextBoxColumn
            // 
            this.iINDataGridViewTextBoxColumn.DataPropertyName = "IIN";
            this.iINDataGridViewTextBoxColumn.HeaderText = "ИИН";
            this.iINDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iINDataGridViewTextBoxColumn.Name = "iINDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Есімі";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Тегі";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            dataGridViewCellStyle1.Format = "(###)-###-##-##";
            dataGridViewCellStyle1.NullValue = null;
            this.numberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.numberDataGridViewTextBoxColumn.HeaderText = "Телефон номеры";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Мекен жайы";
            this.adressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.booksDBDataSet1;
            // 
            // booksDBDataSet1
            // 
            this.booksDBDataSet1.DataSetName = "BooksDBDataSet1";
            this.booksDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // UsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1156, 487);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UsersList";
            this.Text = "UsersList";
            this.Load += new System.EventHandler(this.UsersList_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BooksDBDataSet1 booksDBDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private BooksDBDataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
    }
}