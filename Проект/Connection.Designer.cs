
namespace Проект
{
    partial class Connection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection));
            this.lb1_Connection = new System.Windows.Forms.Label();
            this.lbl2_Connection = new System.Windows.Forms.Label();
            this.lb3_Connection = new System.Windows.Forms.Label();
            this.lbl4_Connection = new System.Windows.Forms.Label();
            this.lbl5_Connection = new System.Windows.Forms.Label();
            this.lbl6_Connection = new System.Windows.Forms.Label();
            this.lbl7_Connection = new System.Windows.Forms.Label();
            this.lbl8_Connection = new System.Windows.Forms.Label();
            this.Host_Connection = new System.Windows.Forms.TextBox();
            this.BD_Connection = new System.Windows.Forms.TextBox();
            this.User_Connection = new System.Windows.Forms.TextBox();
            this.Pass_Connection = new System.Windows.Forms.TextBox();
            this.CharacterSet_Connection = new System.Windows.Forms.TextBox();
            this.Port_Connection = new System.Windows.Forms.NumericUpDown();
            this.Check_Connection = new System.Windows.Forms.Button();
            this.Edit_Connection = new System.Windows.Forms.Button();
            this.Add_Connection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Port_Connection)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1_Connection
            // 
            this.lb1_Connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1_Connection.Location = new System.Drawing.Point(12, 9);
            this.lb1_Connection.Name = "lb1_Connection";
            this.lb1_Connection.Size = new System.Drawing.Size(253, 73);
            this.lb1_Connection.TabIndex = 12;
            this.lb1_Connection.Text = "Пожалуйста, проверьте настройки вашего соединения.";
            this.lb1_Connection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2_Connection
            // 
            this.lbl2_Connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2_Connection.Location = new System.Drawing.Point(12, 82);
            this.lbl2_Connection.Name = "lbl2_Connection";
            this.lbl2_Connection.Size = new System.Drawing.Size(253, 32);
            this.lbl2_Connection.TabIndex = 13;
            this.lbl2_Connection.Text = "В случае, если данные не являются правдивыми, то введите соответствующие.";
            this.lbl2_Connection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb3_Connection
            // 
            this.lb3_Connection.AutoSize = true;
            this.lb3_Connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb3_Connection.Location = new System.Drawing.Point(81, 124);
            this.lb3_Connection.Name = "lb3_Connection";
            this.lb3_Connection.Size = new System.Drawing.Size(41, 16);
            this.lb3_Connection.TabIndex = 18;
            this.lb3_Connection.Text = "Хост:";
            // 
            // lbl4_Connection
            // 
            this.lbl4_Connection.AutoSize = true;
            this.lbl4_Connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl4_Connection.Location = new System.Drawing.Point(81, 166);
            this.lbl4_Connection.Name = "lbl4_Connection";
            this.lbl4_Connection.Size = new System.Drawing.Size(44, 16);
            this.lbl4_Connection.TabIndex = 19;
            this.lbl4_Connection.Text = "Порт:";
            // 
            // lbl5_Connection
            // 
            this.lbl5_Connection.AutoSize = true;
            this.lbl5_Connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl5_Connection.Location = new System.Drawing.Point(81, 208);
            this.lbl5_Connection.Name = "lbl5_Connection";
            this.lbl5_Connection.Size = new System.Drawing.Size(94, 16);
            this.lbl5_Connection.TabIndex = 20;
            this.lbl5_Connection.Text = "База данных:";
            // 
            // lbl6_Connection
            // 
            this.lbl6_Connection.AutoSize = true;
            this.lbl6_Connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl6_Connection.Location = new System.Drawing.Point(81, 250);
            this.lbl6_Connection.Name = "lbl6_Connection";
            this.lbl6_Connection.Size = new System.Drawing.Size(106, 16);
            this.lbl6_Connection.TabIndex = 21;
            this.lbl6_Connection.Text = "Пользователь:";
            // 
            // lbl7_Connection
            // 
            this.lbl7_Connection.AutoSize = true;
            this.lbl7_Connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl7_Connection.Location = new System.Drawing.Point(81, 292);
            this.lbl7_Connection.Name = "lbl7_Connection";
            this.lbl7_Connection.Size = new System.Drawing.Size(60, 16);
            this.lbl7_Connection.TabIndex = 22;
            this.lbl7_Connection.Text = "Пароль:";
            // 
            // lbl8_Connection
            // 
            this.lbl8_Connection.AutoSize = true;
            this.lbl8_Connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl8_Connection.Location = new System.Drawing.Point(81, 334);
            this.lbl8_Connection.Name = "lbl8_Connection";
            this.lbl8_Connection.Size = new System.Drawing.Size(84, 16);
            this.lbl8_Connection.TabIndex = 23;
            this.lbl8_Connection.Text = "Сравнение:";
            // 
            // Host_Connection
            // 
            this.Host_Connection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Host_Connection.Location = new System.Drawing.Point(84, 143);
            this.Host_Connection.Name = "Host_Connection";
            this.Host_Connection.Size = new System.Drawing.Size(128, 20);
            this.Host_Connection.TabIndex = 24;
            // 
            // BD_Connection
            // 
            this.BD_Connection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BD_Connection.Location = new System.Drawing.Point(84, 227);
            this.BD_Connection.Name = "BD_Connection";
            this.BD_Connection.Size = new System.Drawing.Size(128, 20);
            this.BD_Connection.TabIndex = 25;
            // 
            // User_Connection
            // 
            this.User_Connection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.User_Connection.Location = new System.Drawing.Point(84, 269);
            this.User_Connection.Name = "User_Connection";
            this.User_Connection.Size = new System.Drawing.Size(128, 20);
            this.User_Connection.TabIndex = 26;
            // 
            // Pass_Connection
            // 
            this.Pass_Connection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pass_Connection.Location = new System.Drawing.Point(84, 311);
            this.Pass_Connection.Name = "Pass_Connection";
            this.Pass_Connection.Size = new System.Drawing.Size(128, 20);
            this.Pass_Connection.TabIndex = 27;
            // 
            // CharacterSet_Connection
            // 
            this.CharacterSet_Connection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CharacterSet_Connection.Location = new System.Drawing.Point(84, 353);
            this.CharacterSet_Connection.Name = "CharacterSet_Connection";
            this.CharacterSet_Connection.Size = new System.Drawing.Size(128, 20);
            this.CharacterSet_Connection.TabIndex = 28;
            // 
            // Port_Connection
            // 
            this.Port_Connection.Location = new System.Drawing.Point(84, 185);
            this.Port_Connection.Name = "Port_Connection";
            this.Port_Connection.Size = new System.Drawing.Size(128, 20);
            this.Port_Connection.TabIndex = 29;
            // 
            // Check_Connection
            // 
            this.Check_Connection.BackColor = System.Drawing.Color.Transparent;
            this.Check_Connection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Check_Connection.BackgroundImage")));
            this.Check_Connection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Check_Connection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Check_Connection.Location = new System.Drawing.Point(76, 382);
            this.Check_Connection.Name = "Check_Connection";
            this.Check_Connection.Size = new System.Drawing.Size(46, 43);
            this.Check_Connection.TabIndex = 30;
            this.Check_Connection.UseVisualStyleBackColor = false;
            // 
            // Edit_Connection
            // 
            this.Edit_Connection.BackColor = System.Drawing.Color.Transparent;
            this.Edit_Connection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Edit_Connection.BackgroundImage")));
            this.Edit_Connection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Edit_Connection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Connection.Location = new System.Drawing.Point(128, 382);
            this.Edit_Connection.Name = "Edit_Connection";
            this.Edit_Connection.Size = new System.Drawing.Size(46, 43);
            this.Edit_Connection.TabIndex = 31;
            this.Edit_Connection.UseVisualStyleBackColor = false;
            // 
            // Add_Connection
            // 
            this.Add_Connection.BackColor = System.Drawing.Color.Transparent;
            this.Add_Connection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_Connection.BackgroundImage")));
            this.Add_Connection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Add_Connection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Connection.Location = new System.Drawing.Point(179, 382);
            this.Add_Connection.Name = "Add_Connection";
            this.Add_Connection.Size = new System.Drawing.Size(46, 43);
            this.Add_Connection.TabIndex = 32;
            this.Add_Connection.UseVisualStyleBackColor = false;
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(276, 437);
            this.Controls.Add(this.Add_Connection);
            this.Controls.Add(this.Edit_Connection);
            this.Controls.Add(this.Check_Connection);
            this.Controls.Add(this.Port_Connection);
            this.Controls.Add(this.CharacterSet_Connection);
            this.Controls.Add(this.Pass_Connection);
            this.Controls.Add(this.User_Connection);
            this.Controls.Add(this.BD_Connection);
            this.Controls.Add(this.Host_Connection);
            this.Controls.Add(this.lbl8_Connection);
            this.Controls.Add(this.lbl7_Connection);
            this.Controls.Add(this.lbl6_Connection);
            this.Controls.Add(this.lbl5_Connection);
            this.Controls.Add(this.lbl4_Connection);
            this.Controls.Add(this.lb3_Connection);
            this.Controls.Add(this.lbl2_Connection);
            this.Controls.Add(this.lb1_Connection);
            this.Name = "Connection";
            this.Text = "Проверка соединения";
            ((System.ComponentModel.ISupportInitialize)(this.Port_Connection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1_Connection;
        private System.Windows.Forms.Label lbl2_Connection;
        private System.Windows.Forms.Label lb3_Connection;
        private System.Windows.Forms.Label lbl4_Connection;
        private System.Windows.Forms.Label lbl5_Connection;
        private System.Windows.Forms.Label lbl6_Connection;
        private System.Windows.Forms.Label lbl7_Connection;
        private System.Windows.Forms.Label lbl8_Connection;
        private System.Windows.Forms.TextBox Host_Connection;
        private System.Windows.Forms.TextBox BD_Connection;
        private System.Windows.Forms.TextBox User_Connection;
        private System.Windows.Forms.TextBox Pass_Connection;
        private System.Windows.Forms.TextBox CharacterSet_Connection;
        private System.Windows.Forms.NumericUpDown Port_Connection;
        private System.Windows.Forms.Button Check_Connection;
        private System.Windows.Forms.Button Edit_Connection;
        private System.Windows.Forms.Button Add_Connection;
    }
}