
namespace Проект
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.lb1_Autorization = new System.Windows.Forms.Label();
            this.lb3_Autorization = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.Ok_Autorization = new System.Windows.Forms.Button();
            this.lb4_Autorization = new System.Windows.Forms.Label();
            this.Access_Authorization = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb1_Autorization
            // 
            this.lb1_Autorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1_Autorization.Location = new System.Drawing.Point(44, 59);
            this.lb1_Autorization.Name = "lb1_Autorization";
            this.lb1_Autorization.Size = new System.Drawing.Size(205, 88);
            this.lb1_Autorization.TabIndex = 0;
            this.lb1_Autorization.Text = "Пожалуйста, введите данные вашего пользователя.";
            this.lb1_Autorization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb3_Autorization
            // 
            this.lb3_Autorization.AutoSize = true;
            this.lb3_Autorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb3_Autorization.Location = new System.Drawing.Point(86, 150);
            this.lb3_Autorization.Name = "lb3_Autorization";
            this.lb3_Autorization.Size = new System.Drawing.Size(59, 20);
            this.lb3_Autorization.TabIndex = 2;
            this.lb3_Autorization.Text = "Логин:";
            // 
            // tb_login
            // 
            this.tb_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_login.Location = new System.Drawing.Point(90, 173);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(128, 20);
            this.tb_login.TabIndex = 3;
            // 
            // tb_password
            // 
            this.tb_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_password.Location = new System.Drawing.Point(90, 219);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(128, 20);
            this.tb_password.TabIndex = 4;
            // 
            // Ok_Autorization
            // 
            this.Ok_Autorization.BackColor = System.Drawing.Color.Transparent;
            this.Ok_Autorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok_Autorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok_Autorization.Location = new System.Drawing.Point(145, 256);
            this.Ok_Autorization.Name = "Ok_Autorization";
            this.Ok_Autorization.Size = new System.Drawing.Size(73, 36);
            this.Ok_Autorization.TabIndex = 5;
            this.Ok_Autorization.Text = "Вход";
            this.Ok_Autorization.UseVisualStyleBackColor = false;
            this.Ok_Autorization.Click += new System.EventHandler(this.Ok_Autorization_Click);
            // 
            // lb4_Autorization
            // 
            this.lb4_Autorization.AutoSize = true;
            this.lb4_Autorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb4_Autorization.Location = new System.Drawing.Point(86, 196);
            this.lb4_Autorization.Name = "lb4_Autorization";
            this.lb4_Autorization.Size = new System.Drawing.Size(71, 20);
            this.lb4_Autorization.TabIndex = 6;
            this.lb4_Autorization.Text = "Пароль:";
            // 
            // Access_Authorization
            // 
            this.Access_Authorization.BackColor = System.Drawing.Color.Transparent;
            this.Access_Authorization.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Access_Authorization.BackgroundImage")));
            this.Access_Authorization.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Access_Authorization.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Access_Authorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Access_Authorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Access_Authorization.Location = new System.Drawing.Point(12, 304);
            this.Access_Authorization.Name = "Access_Authorization";
            this.Access_Authorization.Size = new System.Drawing.Size(39, 33);
            this.Access_Authorization.TabIndex = 8;
            this.Access_Authorization.UseVisualStyleBackColor = false;
            this.Access_Authorization.Click += new System.EventHandler(this.Access_Authorization_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 50);
            this.label1.TabIndex = 9;
            this.label1.Text = "Авторизация.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(277, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Access_Authorization);
            this.Controls.Add(this.lb4_Autorization);
            this.Controls.Add(this.Ok_Autorization);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.lb3_Autorization);
            this.Controls.Add(this.lb1_Autorization);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1_Autorization;
        private System.Windows.Forms.Label lb3_Autorization;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button Ok_Autorization;
        private System.Windows.Forms.Label lb4_Autorization;
        private System.Windows.Forms.Button Access_Authorization;
        private System.Windows.Forms.Label label1;
    }
}

