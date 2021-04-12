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
    public partial class AddTrainess : Form
    {
        public AddTrainess()
        {
            InitializeComponent();
        }
        private DataTrainess TrainessEdited;

        public AddTrainess(DataTrainess TrainessEdit)
        {
            this.TrainessEdited = TrainessEdit;
            InitializeComponent();


            nud_AddTrainess_class.Value = TrainessEdit.Class;
            tb_AddTrainess_fam.Text = TrainessEdit.Family_name;
            tb_AddTrainess_name.Text = TrainessEdit.First_name;
            tb_AddTrainess_middle.Text = TrainessEdit.Middle_name;
        }

        private void Ok_AddTrainess_Click(object sender, EventArgs e)
        {
            if (nud_AddTrainess_class.Value.ToString().Length > 0 && tb_AddTrainess_fam.Text.Length > 0 && tb_AddTrainess_name.Text.Length > 0 && tb_AddTrainess_middle.Text.Length > 0)
            {
                if (TrainessEdited==null)
                {
                    DataTrainess.TrainessAdd(Convert.ToInt32(nud_AddTrainess_class.Value), tb_AddTrainess_fam.Text, tb_AddTrainess_name.Text, tb_AddTrainess_middle.Text);
                }
                else
                {
                    TrainessEdited.TrainessEdit(Convert.ToInt32(nud_AddTrainess_class.Value), tb_AddTrainess_fam.Text, tb_AddTrainess_name.Text, tb_AddTrainess_middle.Text);
                }
                Close();
            }
            else
            {
                MessageBox.Show("Пожалуйства, заполните все данные!");
            }
        }
    }
}
