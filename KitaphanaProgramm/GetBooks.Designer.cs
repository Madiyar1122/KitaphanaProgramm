
namespace KitaphanaProgramm
{
    partial class GetBooks
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.pnlGet = new System.Windows.Forms.Panel();
            this.pnlPass = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlGet.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1095, 28);
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
            this.қолданушыларToolStripMenuItem.Name = "қолданушыларToolStripMenuItem";
            this.қолданушыларToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.қолданушыларToolStripMenuItem.Text = "Қолданушылар";
            this.қолданушыларToolStripMenuItem.Click += new System.EventHandler(this.қолданушыларToolStripMenuItem_Click);
            // 
            // кітапБеруМекеніToolStripMenuItem
            // 
            this.кітапБеруМекеніToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.кітаптарТізіміToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.кітаптарТізіміToolStripMenuItem.Text = "Кітаптар тізімі";
            this.кітаптарТізіміToolStripMenuItem.Click += new System.EventHandler(this.кітаптарТізіміToolStripMenuItem_Click);
            // 
            // қолданушыларТізіміToolStripMenuItem
            // 
            this.қолданушыларТізіміToolStripMenuItem.Name = "қолданушыларТізіміToolStripMenuItem";
            this.қолданушыларТізіміToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.қолданушыларТізіміToolStripMenuItem.Text = "Қолданушылар тізімі";
            this.қолданушыларТізіміToolStripMenuItem.Click += new System.EventHandler(this.қолданушыларТізіміToolStripMenuItem_Click);
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.отчетToolStripMenuItem.Text = "Есептер";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(191, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(904, 440);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(54)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.PnlNav);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.btnPass);
            this.panel1.Controls.Add(this.btnGet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 655);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.Red;
            this.PnlNav.Location = new System.Drawing.Point(0, 241);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(4, 195);
            this.PnlNav.TabIndex = 5;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(54)))), ((int)(((byte)(192)))));
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFilter.Location = new System.Drawing.Point(0, 516);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(191, 39);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Сүзгі";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            this.btnFilter.Leave += new System.EventHandler(this.btnFilter_Leave);
            // 
            // btnPass
            // 
            this.btnPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(54)))), ((int)(((byte)(192)))));
            this.btnPass.FlatAppearance.BorderSize = 0;
            this.btnPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPass.ForeColor = System.Drawing.Color.Red;
            this.btnPass.Location = new System.Drawing.Point(0, 227);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(191, 49);
            this.btnPass.TabIndex = 1;
            this.btnPass.Text = "Кітапты тапсыру";
            this.btnPass.UseVisualStyleBackColor = false;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            this.btnPass.Leave += new System.EventHandler(this.btnPass_Leave);
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(54)))), ((int)(((byte)(192)))));
            this.btnGet.FlatAppearance.BorderSize = 0;
            this.btnGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGet.ForeColor = System.Drawing.Color.Red;
            this.btnGet.Location = new System.Drawing.Point(0, 110);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(191, 49);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "Кітапты беру";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            this.btnGet.Leave += new System.EventHandler(this.btnGet_Leave);
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.LightGray;
            this.pnlFilter.Controls.Add(this.pnlGet);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFilter.Location = new System.Drawing.Point(191, 474);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(904, 209);
            this.pnlFilter.TabIndex = 4;
            this.pnlFilter.Visible = false;
            // 
            // pnlGet
            // 
            this.pnlGet.BackColor = System.Drawing.Color.LightGray;
            this.pnlGet.Controls.Add(this.pnlPass);
            this.pnlGet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGet.Location = new System.Drawing.Point(0, 0);
            this.pnlGet.Name = "pnlGet";
            this.pnlGet.Size = new System.Drawing.Size(904, 209);
            this.pnlGet.TabIndex = 5;
            this.pnlGet.Visible = false;
            // 
            // pnlPass
            // 
            this.pnlPass.BackColor = System.Drawing.Color.LightGray;
            this.pnlPass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPass.Location = new System.Drawing.Point(0, 0);
            this.pnlPass.Name = "pnlPass";
            this.pnlPass.Size = new System.Drawing.Size(904, 209);
            this.pnlPass.TabIndex = 6;
            this.pnlPass.Visible = false;
            // 
            // GetBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1095, 683);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "GetBooks";
            this.Text = "GetBooks";
            this.Load += new System.EventHandler(this.GetBooks_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlGet.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Panel pnlGet;
        private System.Windows.Forms.Panel pnlPass;
    }
}