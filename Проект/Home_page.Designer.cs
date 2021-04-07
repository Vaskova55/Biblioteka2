
namespace Проект
{
    partial class Home_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_page));
            this.dgv_Home_page = new System.Windows.Forms.DataGridView();
            this.ms_Home_page = new System.Windows.Forms.MenuStrip();
            this.tsmi1_Issuance = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi2_Library = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi3_Treiness = new System.Windows.Forms.ToolStripMenuItem();
            this.списаннаяЛитератураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi4_Accounting_book = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi2_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lb1_Home_page = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.lbl2_Home_page = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.lbl3_Home_page = new System.Windows.Forms.Label();
            this.tb1_Autorization = new System.Windows.Forms.TextBox();
            this.lb4_Home_page = new System.Windows.Forms.Label();
            this.lbl5_Home_page = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl8_Home_page = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl7_Home_page = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl6_Home_page = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Home_page)).BeginInit();
            this.ms_Home_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Home_page
            // 
            this.dgv_Home_page.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Home_page.Location = new System.Drawing.Point(277, 41);
            this.dgv_Home_page.MultiSelect = false;
            this.dgv_Home_page.Name = "dgv_Home_page";
            this.dgv_Home_page.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Home_page.Size = new System.Drawing.Size(550, 423);
            this.dgv_Home_page.TabIndex = 0;
            // 
            // ms_Home_page
            // 
            this.ms_Home_page.AllowMerge = false;
            this.ms_Home_page.AutoSize = false;
            this.ms_Home_page.BackColor = System.Drawing.SystemColors.Control;
            this.ms_Home_page.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ms_Home_page.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi1_Issuance,
            this.tsmi2_Library,
            this.tsmi3_Treiness,
            this.списаннаяЛитератураToolStripMenuItem,
            this.tsmi4_Accounting_book,
            this.tsmi2_Exit});
            this.ms_Home_page.Location = new System.Drawing.Point(0, 0);
            this.ms_Home_page.Name = "ms_Home_page";
            this.ms_Home_page.Size = new System.Drawing.Size(839, 38);
            this.ms_Home_page.TabIndex = 1;
            this.ms_Home_page.Text = "menuStrip1";
            // 
            // tsmi1_Issuance
            // 
            this.tsmi1_Issuance.Name = "tsmi1_Issuance";
            this.tsmi1_Issuance.Size = new System.Drawing.Size(76, 34);
            this.tsmi1_Issuance.Text = "Выдача";
            this.tsmi1_Issuance.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tsmi2_Library
            // 
            this.tsmi2_Library.Name = "tsmi2_Library";
            this.tsmi2_Library.Size = new System.Drawing.Size(106, 34);
            this.tsmi2_Library.Text = "Библиотека";
            this.tsmi2_Library.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tsmi3_Treiness
            // 
            this.tsmi3_Treiness.Name = "tsmi3_Treiness";
            this.tsmi3_Treiness.Size = new System.Drawing.Size(126, 34);
            this.tsmi3_Treiness.Text = "Обучающиеся";
            this.tsmi3_Treiness.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // списаннаяЛитератураToolStripMenuItem
            // 
            this.списаннаяЛитератураToolStripMenuItem.Name = "списаннаяЛитератураToolStripMenuItem";
            this.списаннаяЛитератураToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.списаннаяЛитератураToolStripMenuItem.Text = "Списанная литература";
            // 
            // tsmi4_Accounting_book
            // 
            this.tsmi4_Accounting_book.Name = "tsmi4_Accounting_book";
            this.tsmi4_Accounting_book.Size = new System.Drawing.Size(124, 34);
            this.tsmi4_Accounting_book.Text = "Учётная книга";
            this.tsmi4_Accounting_book.Click += new System.EventHandler(this.tsmi4_Accounting_book_Click);
            // 
            // tsmi2_Exit
            // 
            this.tsmi2_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsmi2_Exit.BackgroundImage")));
            this.tsmi2_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsmi2_Exit.Name = "tsmi2_Exit";
            this.tsmi2_Exit.Size = new System.Drawing.Size(12, 34);
            this.tsmi2_Exit.Click += new System.EventHandler(this.tsmi2_Exit_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(22, 94);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 19);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Всех";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lb1_Home_page
            // 
            this.lb1_Home_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1_Home_page.Location = new System.Drawing.Point(12, 41);
            this.lb1_Home_page.Name = "lb1_Home_page";
            this.lb1_Home_page.Size = new System.Drawing.Size(252, 50);
            this.lb1_Home_page.TabIndex = 12;
            this.lb1_Home_page.Text = "Вывод в таблицу читателей:";
            this.lb1_Home_page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(21, 119);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 19);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Должников";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(21, 194);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(53, 19);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Всей";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // lbl2_Home_page
            // 
            this.lbl2_Home_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2_Home_page.Location = new System.Drawing.Point(12, 141);
            this.lbl2_Home_page.Name = "lbl2_Home_page";
            this.lbl2_Home_page.Size = new System.Drawing.Size(252, 50);
            this.lbl2_Home_page.TabIndex = 15;
            this.lbl2_Home_page.Text = "Вывод в таблицу литературы:";
            this.lbl2_Home_page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.Location = new System.Drawing.Point(21, 246);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(84, 19);
            this.radioButton4.TabIndex = 16;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Выданной";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton5.Location = new System.Drawing.Point(21, 220);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(75, 19);
            this.radioButton5.TabIndex = 17;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "В фонде";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // lbl3_Home_page
            // 
            this.lbl3_Home_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl3_Home_page.Location = new System.Drawing.Point(12, 268);
            this.lbl3_Home_page.Name = "lbl3_Home_page";
            this.lbl3_Home_page.Size = new System.Drawing.Size(252, 50);
            this.lbl3_Home_page.TabIndex = 19;
            this.lbl3_Home_page.Text = "Вывод в таблицу истории литературы:";
            this.lbl3_Home_page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb1_Autorization
            // 
            this.tb1_Autorization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb1_Autorization.Location = new System.Drawing.Point(114, 320);
            this.tb1_Autorization.Name = "tb1_Autorization";
            this.tb1_Autorization.Size = new System.Drawing.Size(128, 20);
            this.tb1_Autorization.TabIndex = 21;
            // 
            // lb4_Home_page
            // 
            this.lb4_Home_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb4_Home_page.Location = new System.Drawing.Point(18, 318);
            this.lb4_Home_page.Name = "lb4_Home_page";
            this.lb4_Home_page.Size = new System.Drawing.Size(90, 21);
            this.lb4_Home_page.TabIndex = 22;
            this.lb4_Home_page.Text = "Автор:";
            // 
            // lbl5_Home_page
            // 
            this.lbl5_Home_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl5_Home_page.Location = new System.Drawing.Point(18, 343);
            this.lbl5_Home_page.Name = "lbl5_Home_page";
            this.lbl5_Home_page.Size = new System.Drawing.Size(90, 21);
            this.lbl5_Home_page.TabIndex = 24;
            this.lbl5_Home_page.Text = "Название:";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Location = new System.Drawing.Point(114, 345);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 23;
            // 
            // lbl8_Home_page
            // 
            this.lbl8_Home_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl8_Home_page.Location = new System.Drawing.Point(23, 443);
            this.lbl8_Home_page.Name = "lbl8_Home_page";
            this.lbl8_Home_page.Size = new System.Drawing.Size(90, 21);
            this.lbl8_Home_page.TabIndex = 29;
            this.lbl8_Home_page.Text = "Имя:";
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox2.Location = new System.Drawing.Point(119, 445);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 20);
            this.textBox2.TabIndex = 28;
            // 
            // lbl7_Home_page
            // 
            this.lbl7_Home_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl7_Home_page.Location = new System.Drawing.Point(23, 418);
            this.lbl7_Home_page.Name = "lbl7_Home_page";
            this.lbl7_Home_page.Size = new System.Drawing.Size(90, 21);
            this.lbl7_Home_page.TabIndex = 27;
            this.lbl7_Home_page.Text = "Фамилия:";
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox3.Location = new System.Drawing.Point(119, 420);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 20);
            this.textBox3.TabIndex = 26;
            // 
            // lbl6_Home_page
            // 
            this.lbl6_Home_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl6_Home_page.Location = new System.Drawing.Point(17, 368);
            this.lbl6_Home_page.Name = "lbl6_Home_page";
            this.lbl6_Home_page.Size = new System.Drawing.Size(252, 50);
            this.lbl6_Home_page.TabIndex = 25;
            this.lbl6_Home_page.Text = "Вывод в таблицу истории читателя:";
            this.lbl6_Home_page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 484);
            this.Controls.Add(this.lbl8_Home_page);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl7_Home_page);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbl6_Home_page);
            this.Controls.Add(this.lbl5_Home_page);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb4_Home_page);
            this.Controls.Add(this.tb1_Autorization);
            this.Controls.Add(this.lbl3_Home_page);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.lbl2_Home_page);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.lb1_Home_page);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dgv_Home_page);
            this.Controls.Add(this.ms_Home_page);
            this.MainMenuStrip = this.ms_Home_page;
            this.Name = "Home_page";
            this.Text = "Главная страница";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Home_page)).EndInit();
            this.ms_Home_page.ResumeLayout(false);
            this.ms_Home_page.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Home_page;
        private System.Windows.Forms.MenuStrip ms_Home_page;
        private System.Windows.Forms.ToolStripMenuItem tsmi1_Issuance;
        private System.Windows.Forms.ToolStripMenuItem tsmi2_Library;
        private System.Windows.Forms.ToolStripMenuItem tsmi3_Treiness;
        private System.Windows.Forms.ToolStripMenuItem tsmi4_Accounting_book;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lb1_Home_page;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label lbl2_Home_page;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label lbl3_Home_page;
        private System.Windows.Forms.TextBox tb1_Autorization;
        private System.Windows.Forms.Label lb4_Home_page;
        private System.Windows.Forms.Label lbl5_Home_page;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl8_Home_page;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl7_Home_page;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl6_Home_page;
        private System.Windows.Forms.ToolStripMenuItem списаннаяЛитератураToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi2_Exit;
    }
}