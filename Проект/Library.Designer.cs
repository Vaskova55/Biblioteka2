
namespace Проект
{
    partial class Library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library));
            this.dgv_Library = new System.Windows.Forms.DataGridView();
            this.Update_Library = new System.Windows.Forms.Button();
            this.Serch_Library = new System.Windows.Forms.Button();
            this.Delete_Library = new System.Windows.Forms.Button();
            this.Edit_Library = new System.Windows.Forms.Button();
            this.Add_Library = new System.Windows.Forms.Button();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publishing_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Library)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Library
            // 
            this.dgv_Library.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Library.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type,
            this.Class,
            this.Name,
            this.Author,
            this.Publisher,
            this.Publishing_year});
            this.dgv_Library.Location = new System.Drawing.Point(83, 12);
            this.dgv_Library.MultiSelect = false;
            this.dgv_Library.Name = "dgv_Library";
            this.dgv_Library.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Library.Size = new System.Drawing.Size(360, 262);
            this.dgv_Library.TabIndex = 6;
            // 
            // Update_Library
            // 
            this.Update_Library.BackColor = System.Drawing.Color.Transparent;
            this.Update_Library.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Update_Library.BackgroundImage")));
            this.Update_Library.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Update_Library.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Library.Location = new System.Drawing.Point(12, 12);
            this.Update_Library.Name = "Update_Library";
            this.Update_Library.Size = new System.Drawing.Size(46, 43);
            this.Update_Library.TabIndex = 11;
            this.Update_Library.UseVisualStyleBackColor = false;
            // 
            // Serch_Library
            // 
            this.Serch_Library.BackColor = System.Drawing.Color.Transparent;
            this.Serch_Library.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Serch_Library.BackgroundImage")));
            this.Serch_Library.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Serch_Library.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Serch_Library.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Serch_Library.Location = new System.Drawing.Point(12, 61);
            this.Serch_Library.Name = "Serch_Library";
            this.Serch_Library.Size = new System.Drawing.Size(46, 40);
            this.Serch_Library.TabIndex = 10;
            this.Serch_Library.UseVisualStyleBackColor = false;
            // 
            // Delete_Library
            // 
            this.Delete_Library.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Delete_Library.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete_Library.BackgroundImage")));
            this.Delete_Library.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Delete_Library.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Library.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_Library.Location = new System.Drawing.Point(12, 205);
            this.Delete_Library.Name = "Delete_Library";
            this.Delete_Library.Size = new System.Drawing.Size(46, 40);
            this.Delete_Library.TabIndex = 9;
            this.Delete_Library.UseVisualStyleBackColor = false;
            // 
            // Edit_Library
            // 
            this.Edit_Library.BackColor = System.Drawing.Color.Transparent;
            this.Edit_Library.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Edit_Library.BackgroundImage")));
            this.Edit_Library.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Edit_Library.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Library.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_Library.Location = new System.Drawing.Point(12, 158);
            this.Edit_Library.Name = "Edit_Library";
            this.Edit_Library.Size = new System.Drawing.Size(46, 41);
            this.Edit_Library.TabIndex = 8;
            this.Edit_Library.UseVisualStyleBackColor = false;
            // 
            // Add_Library
            // 
            this.Add_Library.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_Library.BackgroundImage")));
            this.Add_Library.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Add_Library.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Library.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Library.Location = new System.Drawing.Point(12, 107);
            this.Add_Library.Name = "Add_Library";
            this.Add_Library.Size = new System.Drawing.Size(46, 41);
            this.Add_Library.TabIndex = 7;
            this.Add_Library.UseVisualStyleBackColor = true;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.HeaderText = "Тип";
            this.type.Name = "type";
            // 
            // Class
            // 
            this.Class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Class.HeaderText = "Класс";
            this.Class.Name = "Class";
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.HeaderText = "Название";
            this.Name.Name = "Name";
            // 
            // Author
            // 
            this.Author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Author.HeaderText = "Автор";
            this.Author.Name = "Author";
            // 
            // Publisher
            // 
            this.Publisher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Publisher.HeaderText = "Издательство";
            this.Publisher.Name = "Publisher";
            // 
            // Publishing_year
            // 
            this.Publishing_year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Publishing_year.HeaderText = "Год публикации";
            this.Publishing_year.Name = "Publishing_year";
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(492, 282);
            this.Controls.Add(this.Update_Library);
            this.Controls.Add(this.Serch_Library);
            this.Controls.Add(this.Delete_Library);
            this.Controls.Add(this.Edit_Library);
            this.Controls.Add(this.Add_Library);
            this.Controls.Add(this.dgv_Library);
            this.Name = "Library";
            this.Text = "Библиотека";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Library)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Update_Library;
        private System.Windows.Forms.Button Serch_Library;
        private System.Windows.Forms.Button Delete_Library;
        private System.Windows.Forms.Button Edit_Library;
        private System.Windows.Forms.Button Add_Library;
        private System.Windows.Forms.DataGridView dgv_Library;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publishing_year;
    }
}