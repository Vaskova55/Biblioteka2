﻿
namespace Проект
{
    partial class Access
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
            this.lbl1_Access = new System.Windows.Forms.Label();
            this.lbl2_Access = new System.Windows.Forms.Label();
            this.Pass_Access = new System.Windows.Forms.TextBox();
            this.Ok_Access = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1_Access
            // 
            this.lbl1_Access.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1_Access.Location = new System.Drawing.Point(12, 9);
            this.lbl1_Access.Name = "lbl1_Access";
            this.lbl1_Access.Size = new System.Drawing.Size(211, 89);
            this.lbl1_Access.TabIndex = 0;
            this.lbl1_Access.Text = "Пожалуйста, подтвердите ваш доступ.";
            this.lbl1_Access.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2_Access
            // 
            this.lbl2_Access.AutoSize = true;
            this.lbl2_Access.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2_Access.Location = new System.Drawing.Point(16, 101);
            this.lbl2_Access.Name = "lbl2_Access";
            this.lbl2_Access.Size = new System.Drawing.Size(71, 20);
            this.lbl2_Access.TabIndex = 1;
            this.lbl2_Access.Text = "Пароль:";
            // 
            // Pass_Access
            // 
            this.Pass_Access.Location = new System.Drawing.Point(93, 103);
            this.Pass_Access.Name = "Pass_Access";
            this.Pass_Access.Size = new System.Drawing.Size(118, 20);
            this.Pass_Access.TabIndex = 2;
            // 
            // Ok_Access
            // 
            this.Ok_Access.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok_Access.Location = new System.Drawing.Point(174, 141);
            this.Ok_Access.Name = "Ok_Access";
            this.Ok_Access.Size = new System.Drawing.Size(37, 27);
            this.Ok_Access.TabIndex = 3;
            this.Ok_Access.Text = "Ок";
            this.Ok_Access.UseVisualStyleBackColor = true;
            this.Ok_Access.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(235, 180);
            this.Controls.Add(this.Ok_Access);
            this.Controls.Add(this.Pass_Access);
            this.Controls.Add(this.lbl2_Access);
            this.Controls.Add(this.lbl1_Access);
            this.Name = "Access";
            this.Text = "Проверка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1_Access;
        private System.Windows.Forms.Label lbl2_Access;
        private System.Windows.Forms.TextBox Pass_Access;
        private System.Windows.Forms.Button Ok_Access;
    }
}