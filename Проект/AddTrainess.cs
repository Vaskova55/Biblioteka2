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
            DataTrainess.TrainessAdd(Convert.ToInt32(Class.Text), Family_name.Text, First_name.Text, Middle_name.Text);
        }
    }
}
