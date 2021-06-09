
namespace KitaphanaProgramm
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // мәзірToolStripMenuItem
            // 
            this.мәзірToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.мәзірToolStripMenuItem.Name = "мәзірToolStripMenuItem";
            this.мәзірToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.мәзірToolStripMenuItem.Text = "Мәзір";
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
            this.қолданушыларToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.қолданушыларToolStripMenuItem.Text = "Оқырмандар";
            this.қолданушыларToolStripMenuItem.Click += new System.EventHandler(this.қолданушыларToolStripMenuItem_Click);
            // 
            // кітапБеруМекеніToolStripMenuItem
            // 
            this.кітапБеруМекеніToolStripMenuItem.Name = "кітапБеруМекеніToolStripMenuItem";
            this.кітапБеруМекеніToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.кітапБеруМекеніToolStripMenuItem.Text = "Кітап беру мекені";
            this.кітапБеруМекеніToolStripMenuItem.Click += new System.EventHandler(this.кітапБеруМекеніToolStripMenuItem_Click);
            // 
            // редакторлауToolStripMenuItem
            // 
            this.редакторлауToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кітаптарТізіміToolStripMenuItem,
            this.қолданушыларТізіміToolStripMenuItem});
            this.редакторлауToolStripMenuItem.Name = "редакторлауToolStripMenuItem";
            this.редакторлауToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.редакторлауToolStripMenuItem.Text = "Редакторлау";
            this.редакторлауToolStripMenuItem.Click += new System.EventHandler(this.редакторлауToolStripMenuItem_Click);
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
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(12, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Кітап беру";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(742, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "!";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoEllipsis = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Location = new System.Drawing.Point(12, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Жаңа оқырманды енгізу";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Мәзір";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

