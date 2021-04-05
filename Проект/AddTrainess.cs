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

        private void Ok_AddTrainess_Click(object sender, EventArgs e)
        {
            DataTrainess.TrainessAdd(Convert.ToInt32(nud_AddTrainess_class.Value), tb_AddTrainess_fam.Text, tb_AddTrainess_name.Text, tb3_AddTrainess_middle.Text);
        }
    }
}
