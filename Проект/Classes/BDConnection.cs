using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект.Classes
{
    class BDConnection
    {
        public static DataTable Select(string sql)
        {
            MySqlConnectionStringBuilder connectBuilder = new MySqlConnectionStringBuilder();
            connectBuilder.UserID = "ISP333_VaskovaAN";
            connectBuilder.Server = "192.168.201.12";
            connectBuilder.Port = 3306;
            connectBuilder.Password = "Vaskova333";
            connectBuilder.Database = "ISP333_VaskovaAN_biblioteka";
            connectBuilder.CharacterSet = "utf8";
            MySqlConnection connect = new MySqlConnection();
            MySqlCommand command = new MySqlCommand(sql, connect);
            DataTable data = new DataTable();
            try
            {
                connect.Open();
                data.Load(command.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            return data;
        }
    }
}
