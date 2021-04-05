
namespace Проект
{
    partial class Issuance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Issuance));
            this.dgv_Issuance = new System.Windows.Forms.DataGridView();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Family_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Middle_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update_Issuance = new System.Windows.Forms.Button();
            this.Serch_Issuance = new System.Windows.Forms.Button();
            this.Delete_Issuance = new System.Windows.Forms.Button();
            this.Edit_Issuance = new System.Windows.Forms.Button();
            this.Add_Issuance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Issuance)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Issuance
            // 
            this.dgv_Issuance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Issuance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Class,
            this.Family_name,
            this.First_name,
            this.Middle_name});
            this.dgv_Issuance.Location = new System.Drawing.Point(83, 12);
            this.dgv_Issuance.MultiSelect = false;
            this.dgv_Issuance.Name = "dgv_Issuance";
            this.dgv_Issuance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Issuance.Size = new System.Drawing.Size(398, 262);
            this.dgv_Issuance.TabIndex = 6;
            // 
            // Class
            // 
            this.Class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Class.HeaderText = "Класс";
            this.Class.Name = "Class";
            // 
            // Family_name
            // 
            this.Family_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Family_name.HeaderText = "Фамилия";
            this.Family_name.Name = "Family_name";
            // 
            // First_name
            // 
            this.First_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.First_name.HeaderText = "Имя";
            this.First_name.Name = "First_name";
            // 
            // Middle_name
            // 
            this.Middle_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Middle_name.HeaderText = "Отчество";
            this.Middle_name.Name = "Middle_name";
            // 
            // Update_Issuance
            // 
            this.Update_Issuance.BackColor = System.Drawing.Color.Transparent;
            this.Update_Issuance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Update_Issuance.BackgroundImage")));
            this.Update_Issuance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Update_Issuance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Issuance.Location = new System.Drawing.Point(12, 12);
            this.Update_Issuance.Name = "Update_Issuance";
            this.Update_Issuance.Size = new System.Drawing.Size(46, 43);
            this.Update_Issuance.TabIndex = 11;
            this.Update_Issuance.UseVisualStyleBackColor = false;
            // 
            // Serch_Issuance
            // 
            this.Serch_Issuance.BackColor = System.Drawing.Color.Transparent;
            this.Serch_Issuance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Serch_Issuance.BackgroundImage")));
            this.Serch_Issuance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Serch_Issuance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Serch_Issuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Serch_Issuance.Location = new System.Drawing.Point(12, 61);
            this.Serch_Issuance.Name = "Serch_Issuance";
            this.Serch_Issuance.Size = new System.Drawing.Size(46, 40);
            this.Serch_Issuance.TabIndex = 10;
            this.Serch_Issuance.UseVisualStyleBackColor = false;
            // 
            // Delete_Issuance
            // 
            this.Delete_Issuance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Delete_Issuance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete_Issuance.BackgroundImage")));
            this.Delete_Issuance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Delete_Issuance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Issuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_Issuance.Location = new System.Drawing.Point(12, 205);
            this.Delete_Issuance.Name = "Delete_Issuance";
            this.Delete_Issuance.Size = new System.Drawing.Size(46, 40);
            this.Delete_Issuance.TabIndex = 9;
            this.Delete_Issuance.UseVisualStyleBackColor = false;
            // 
            // Edit_Issuance
            // 
            this.Edit_Issuance.BackColor = System.Drawing.Color.Transparent;
            this.Edit_Issuance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Edit_Issuance.BackgroundImage")));
            this.Edit_Issuance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Edit_Issuance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Issuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_Issuance.Location = new System.Drawing.Point(12, 158);
            this.Edit_Issuance.Name = "Edit_Issuance";
            this.Edit_Issuance.Size = new System.Drawing.Size(46, 41);
            this.Edit_Issuance.TabIndex = 8;
            this.Edit_Issuance.UseVisualStyleBackColor = false;
            // 
            // Add_Issuance
            // 
            this.Add_Issuance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_Issuance.BackgroundImage")));
            this.Add_Issuance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Add_Issuance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Issuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Issuance.Location = new System.Drawing.Point(12, 107);
            this.Add_Issuance.Name = "Add_Issuance";
            this.Add_Issuance.Size = new System.Drawing.Size(46, 41);
            this.Add_Issuance.TabIndex = 7;
            this.Add_Issuance.UseVisualStyleBackColor = true;
            // 
            // Issuance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(490, 284);
            this.Controls.Add(this.Update_Issuance);
            this.Controls.Add(this.Serch_Issuance);
            this.Controls.Add(this.Delete_Issuance);
            this.Controls.Add(this.Edit_Issuance);
            this.Controls.Add(this.Add_Issuance);
            this.Controls.Add(this.dgv_Issuance);
            this.Name = "Issuance";
            this.Text = "Выдача литературы";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Issuance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Update_Issuance;
        private System.Windows.Forms.Button Serch_Issuance;
        private System.Windows.Forms.Button Delete_Issuance;
        private System.Windows.Forms.Button Edit_Issuance;
        private System.Windows.Forms.Button Add_Issuance;
        private System.Windows.Forms.DataGridView dgv_Issuance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Family_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Middle_name;
    }
}