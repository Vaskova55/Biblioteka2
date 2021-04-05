using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект.Classes
{
    public class DataUser
    {
        public string family_name;
        public string first_name;
        public int access_level;
        public string login;
        public string password;

        public DataUser(DataRow row)
        {
            family_name = Convert.ToString(row["family_name"]);
            first_name = Convert.ToString(row["first_name"]);
            access_level = Convert.ToInt32(row["access_level"]);
            login = Convert.ToString(row["login"]);
            password = Convert.ToString(row["password"]);
        }

        public static List<DataUser> Select()
        {
            List<DataUser> listUser = new List<DataUser>();
            DataTable data = BDConnection.Select("SELECT * FROM biblioteka.users;");
            foreach (DataRow row in data.Rows)
            {
                listUser.Add(new DataUser(row));
            }
            return listUser;
        }

        public static bool Login(string login, string password, out DataUser listUser)
        {
            DataTable data = BDConnection.Select("SELECT * FROM users WHERE login = '"+ login + "' and password = '"+ password +"';");
            listUser = null;
            if (data.Rows.Count > 0)
            {
                listUser = new DataUser(data.Rows[0]);
                return true;
            }
            return false;
        }
    }
}
