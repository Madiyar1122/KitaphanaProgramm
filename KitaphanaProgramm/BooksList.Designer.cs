
namespace KitaphanaProgramm
{
    partial class BooksList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.booksIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.janrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avtorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksDBDataSet = new KitaphanaProgramm.BooksDBDataSet();
            this.booksTableAdapter = new KitaphanaProgramm.BooksDBDataSetTableAdapters.BooksTableAdapter();
            this.booksDBDataSet1 = new KitaphanaProgramm.BooksDBDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1159, 30);
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
            this.қолданушыларToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.қолданушыларToolStripMenuItem.Text = "Қолданушылар";
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
            this.кітаптарТізіміToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.кітаптарТізіміToolStripMenuItem.Name = "кітаптарТізіміToolStripMenuItem";
            this.кітаптарТізіміToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.кітаптарТізіміToolStripMenuItem.Text = "Кітаптар тізімі";
            // 
            // қолданушыларТізіміToolStripMenuItem
            // 
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.booksIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.janrDataGridViewTextBoxColumn,
            this.avtorDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.articulDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.booksBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1159, 277);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // booksIDDataGridViewTextBoxColumn
            // 
            this.booksIDDataGridViewTextBoxColumn.DataPropertyName = "BooksID";
            this.booksIDDataGridViewTextBoxColumn.HeaderText = "BooksID";
            this.booksIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.booksIDDataGridViewTextBoxColumn.Name = "booksIDDataGridViewTextBoxColumn";
            this.booksIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // janrDataGridViewTextBoxColumn
            // 
            this.janrDataGridViewTextBoxColumn.DataPropertyName = "Janr";
            this.janrDataGridViewTextBoxColumn.HeaderText = "Janr";
            this.janrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.janrDataGridViewTextBoxColumn.Name = "janrDataGridViewTextBoxColumn";
            // 
            // avtorDataGridViewTextBoxColumn
            // 
            this.avtorDataGridViewTextBoxColumn.DataPropertyName = "Avtor";
            this.avtorDataGridViewTextBoxColumn.HeaderText = "Avtor";
            this.avtorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.avtorDataGridViewTextBoxColumn.Name = "avtorDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // articulDataGridViewTextBoxColumn
            // 
            this.articulDataGridViewTextBoxColumn.DataPropertyName = "Articul";
            this.articulDataGridViewTextBoxColumn.HeaderText = "Articul";
            this.articulDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.articulDataGridViewTextBoxColumn.Name = "articulDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.booksDBDataSetBindingSource;
            // 
            // booksDBDataSetBindingSource
            // 
            this.booksDBDataSetBindingSource.DataSource = this.booksDBDataSet;
            this.booksDBDataSetBindingSource.Position = 0;
            // 
            // booksDBDataSet
            // 
            this.booksDBDataSet.DataSetName = "BooksDBDataSet";
            this.booksDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // booksDBDataSet1
            // 
            this.booksDBDataSet1.DataSetName = "BooksDBDataSet";
            this.booksDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.booksBindingSource1;
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.booksDBDataSetBindingSource;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(12, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Жаңа кітапты қосу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(961, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Кітапты жою";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(1089, 366);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 30);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(733, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Жоятын кітаптын Id санын енгізініз";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(430, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 45);
            this.button3.TabIndex = 7;
            this.button3.Text = "Ref";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BooksList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1159, 510);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "BooksList";
            this.Text = "BooksList";
            this.Load += new System.EventHandler(this.BooksList_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource booksDBDataSetBindingSource;
        private BooksDBDataSet booksDBDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private BooksDBDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn booksIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn janrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avtorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private BooksDBDataSet booksDBDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}