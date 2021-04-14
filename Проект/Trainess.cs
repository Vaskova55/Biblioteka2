using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Проект.Classes;

namespace Проект
{
    public partial class Trainess : Form
    {
        public Trainess()
        {
            InitializeComponent();
        }

        private void Update_Trainess_Click(object sender, EventArgs e)
        {
            UpdateData_Trainess();
        }

        private void UpdateData_Trainess()
        {
            dgv_Trainess.Rows.Clear();
            foreach (DataTrainess listTreiness in DataTrainess.Select(tb_SearchTrainess.Text))
            {
                int r = dgv_Trainess.Rows.Add(listTreiness.Class, listTreiness.Family_name, listTreiness.First_name, listTreiness.Middle_name);
                dgv_Trainess.Rows[r].Tag = listTreiness;
            }
        }

        private void Delete_Trainess_Click(object sender, EventArgs e)
        {
            if (dgv_Trainess.SelectedRows.Count > 0)
            {
                DataTrainess trainess = dgv_Trainess.SelectedRows[0].Tag as DataTrainess;
                trainess.Delete();
                UpdateData_Trainess();
            }
        }

        private void Add_Trainess_Click(object sender, EventArgs e)
        {
            AddTrainess f_at = new AddTrainess();
            f_at.Show();
        }

        private void Search_Trainess_Click(object sender, EventArgs e)
        {
            SearchTrainess f_st = new SearchTrainess();
            f_st.Show();
        }

        private void Edit_Trainess_Click(object sender, EventArgs e)
        {
            if (dgv_Trainess.SelectedRows.Count > 0)
            {
                DataTrainess trainess = dgv_Trainess.SelectedRows[0].Tag as DataTrainess;
                AddTrainess f_at = new AddTrainess(trainess);
                f_at.Show();
                Update();
            }
        }

        private void Export_Trainess_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Файлы excel|*.xlsx";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                List<DataTrainess> listTrainesses = DataTrainess.Select("");
                string[,] values = new string[listTrainesses.Count + 1, 5];

                values[0, 0] = "Класс";
                values[0, 1] = "Фамилия";
                values[0, 2] = "Имя";
                values[0, 3] = "Отчество";

                for (int i = 0; i < listTrainesses.Count; i++)
                {
                    values[i + 1, 0] = listTrainesses[i].Class.ToString();
                    values[i + 1, 1] = listTrainesses[i].Family_name;
                    values[i + 1, 2] = listTrainesses[i].First_name;
                    values[i + 1, 3] = listTrainesses[i].Middle_name;
                }
                ExportData.ExportExcel(dialog.FileName, "Обучающиеся", values);
            }
        }
    }
}
