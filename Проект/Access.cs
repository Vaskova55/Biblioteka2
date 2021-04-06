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
    public partial class Access : Form
    {
        public Access()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (DataUser.Login(Login_Access.Text, Pass_Access.Text, out DataUser listUser))
            {
                if (listUser.access_level == 1)
                {
                    Connection f_con = new Connection();
                    f_con.Show();
                }
                else
                {
                    MessageBox.Show("Ваш пользователь не имеет доступа!");
                }
            }
            else
            { MessageBox.Show("Неверный логин или пароль!"); }
        }
    }
}
