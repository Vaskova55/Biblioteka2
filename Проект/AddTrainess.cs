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
        DataTrainess Updat;

        public AddTrainess(DataTrainess TrainessUpdat)
        {
            this.Updat = TrainessUpdat;
            InitializeComponent();


            nud_AddTrainess_class.Value = TrainessUpdat.Class;
            tb_AddTrainess_fam.Text = TrainessUpdat.Family_name;
            tb_AddTrainess_name.Text = TrainessUpdat.First_name;
            tb_AddTrainess_middle.Text = TrainessUpdat.Middle_name;
        }

        private void Ok_AddTrainess_Click(object sender, EventArgs e)
        {
            if (nud_AddTrainess_class.Value.ToString().Length > 0 && tb_AddTrainess_fam.Text.Length > 0 && tb_AddTrainess_name.Text.Length > 0 && tb_AddTrainess_middle.Text.Length > 0)
            {
                if (Updat==null)
                {
                    DataTrainess.TrainessAdd(Convert.ToInt32(nud_AddTrainess_class.Value), tb_AddTrainess_fam.Text, tb_AddTrainess_name.Text, tb_AddTrainess_middle.Text);
                }
                else
                {
                    Updat.TrainessUpdat(Convert.ToInt32(id_Trainess.Text), Convert.ToInt32(nud_AddTrainess_class.Value), tb_AddTrainess_fam.Text, tb_AddTrainess_name.Text, tb_AddTrainess_middle.Text);
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
