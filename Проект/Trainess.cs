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
            foreach (DataTrainess listTreiness in DataTrainess.Select())
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
    }
}
