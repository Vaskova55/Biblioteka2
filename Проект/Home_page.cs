using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект
{
    public partial class Home_page : Form
    {
        public Home_page()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Trainess f_tr = new Trainess();
            f_tr.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LibraryForm f_l = new LibraryForm();
            f_l.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Issuance f_is = new Issuance();
            f_is.Show();
        }

        private void tsmi2_Exit_Click(object sender, EventArgs e)
        {
            Authorization f_a = new Authorization();
            f_a.Show();
            Hide();
        }

        private void tsmi4_Accounting_book_Click(object sender, EventArgs e)
        {

        }
    }
}
