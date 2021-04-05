
namespace Проект
{
    partial class SearchTrainess
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
            this.lb1_SearchTrainess = new System.Windows.Forms.Label();
            this.lbl2_SearchTrainess = new System.Windows.Forms.Label();
            this.lb4_SearchTrainess = new System.Windows.Forms.Label();
            this.cb_SearchTrainess = new System.Windows.Forms.ComboBox();
            this.tb1_SearchTrainess = new System.Windows.Forms.TextBox();
            this.lb5_SearchTrainess = new System.Windows.Forms.Label();
            this.lbl3_SearchTrainess = new System.Windows.Forms.Label();
            this.Search_SearchTrainess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb1_SearchTrainess
            // 
            this.lb1_SearchTrainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1_SearchTrainess.Location = new System.Drawing.Point(15, 9);
            this.lb1_SearchTrainess.Name = "lb1_SearchTrainess";
            this.lb1_SearchTrainess.Size = new System.Drawing.Size(253, 50);
            this.lb1_SearchTrainess.TabIndex = 11;
            this.lb1_SearchTrainess.Text = "Поиск данных.";
            this.lb1_SearchTrainess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2_SearchTrainess
            // 
            this.lbl2_SearchTrainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2_SearchTrainess.Location = new System.Drawing.Point(12, 59);
            this.lbl2_SearchTrainess.Name = "lbl2_SearchTrainess";
            this.lbl2_SearchTrainess.Size = new System.Drawing.Size(256, 56);
            this.lbl2_SearchTrainess.TabIndex = 12;
            this.lbl2_SearchTrainess.Text = "Пожалуйста, введите критерии для поиска.";
            this.lbl2_SearchTrainess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb4_SearchTrainess
            // 
            this.lb4_SearchTrainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb4_SearchTrainess.Location = new System.Drawing.Point(28, 161);
            this.lb4_SearchTrainess.Name = "lb4_SearchTrainess";
            this.lb4_SearchTrainess.Size = new System.Drawing.Size(90, 21);
            this.lb4_SearchTrainess.TabIndex = 17;
            this.lb4_SearchTrainess.Text = "Критерий:";
            // 
            // cb_SearchTrainess
            // 
            this.cb_SearchTrainess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_SearchTrainess.FormattingEnabled = true;
            this.cb_SearchTrainess.Items.AddRange(new object[] {
            "Администратор",
            "Обучающийся"});
            this.cb_SearchTrainess.Location = new System.Drawing.Point(125, 161);
            this.cb_SearchTrainess.Name = "cb_SearchTrainess";
            this.cb_SearchTrainess.Size = new System.Drawing.Size(128, 21);
            this.cb_SearchTrainess.TabIndex = 18;
            // 
            // tb1_SearchTrainess
            // 
            this.tb1_SearchTrainess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb1_SearchTrainess.Location = new System.Drawing.Point(125, 198);
            this.tb1_SearchTrainess.Name = "tb1_SearchTrainess";
            this.tb1_SearchTrainess.Size = new System.Drawing.Size(128, 20);
            this.tb1_SearchTrainess.TabIndex = 20;
            // 
            // lb5_SearchTrainess
            // 
            this.lb5_SearchTrainess.AutoSize = true;
            this.lb5_SearchTrainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb5_SearchTrainess.Location = new System.Drawing.Point(28, 198);
            this.lb5_SearchTrainess.Name = "lb5_SearchTrainess";
            this.lb5_SearchTrainess.Size = new System.Drawing.Size(90, 20);
            this.lb5_SearchTrainess.TabIndex = 19;
            this.lb5_SearchTrainess.Text = "Параметр:";
            // 
            // lbl3_SearchTrainess
            // 
            this.lbl3_SearchTrainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl3_SearchTrainess.Location = new System.Drawing.Point(16, 115);
            this.lbl3_SearchTrainess.Name = "lbl3_SearchTrainess";
            this.lbl3_SearchTrainess.Size = new System.Drawing.Size(252, 35);
            this.lbl3_SearchTrainess.TabIndex = 21;
            this.lbl3_SearchTrainess.Text = " Процесс отбора является автоматическим.";
            this.lbl3_SearchTrainess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Search_SearchTrainess
            // 
            this.Search_SearchTrainess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_SearchTrainess.Location = new System.Drawing.Point(59, 233);
            this.Search_SearchTrainess.Name = "Search_SearchTrainess";
            this.Search_SearchTrainess.Size = new System.Drawing.Size(180, 19);
            this.Search_SearchTrainess.TabIndex = 23;
            this.Search_SearchTrainess.Text = "Больше параметров для поиска";
            this.Search_SearchTrainess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchTrainess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(280, 427);
            this.Controls.Add(this.Search_SearchTrainess);
            this.Controls.Add(this.lbl3_SearchTrainess);
            this.Controls.Add(this.tb1_SearchTrainess);
            this.Controls.Add(this.lb5_SearchTrainess);
            this.Controls.Add(this.cb_SearchTrainess);
            this.Controls.Add(this.lb4_SearchTrainess);
            this.Controls.Add(this.lbl2_SearchTrainess);
            this.Controls.Add(this.lb1_SearchTrainess);
            this.Name = "SearchTrainess";
            this.Text = "Поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb1_SearchTrainess;
        private System.Windows.Forms.Label lbl2_SearchTrainess;
        private System.Windows.Forms.Label lb4_SearchTrainess;
        private System.Windows.Forms.ComboBox cb_SearchTrainess;
        private System.Windows.Forms.TextBox tb1_SearchTrainess;
        private System.Windows.Forms.Label lb5_SearchTrainess;
        private System.Windows.Forms.Label lbl3_SearchTrainess;
        private System.Windows.Forms.Label Search_SearchTrainess;
    }
}