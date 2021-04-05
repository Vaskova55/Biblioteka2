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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Access_Authorization_Click(object sender, EventArgs e)
        { 
            Access f2 = new Access();
            f2.ShowDialog();
        }

        private void Ok_Autorization_Click(object sender, EventArgs e)
        {
            if (DataUser.Login(tb_login.Text, tb_password.Text, out DataUser listUser))
            {
                if (listUser.access_level == 1)
                {
                    Home_page f_hp = new Home_page();
                    f_hp.Show();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, проверьте ваш логин и пароль");
                }
            }
            else
            { MessageBox.Show("Неверный логин или пароль!"); }
        }
    }
}
