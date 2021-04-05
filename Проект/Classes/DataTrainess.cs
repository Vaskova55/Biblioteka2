using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект.Classes
{
    public class DataTrainess
    {
        public int idTrainess;
        public int Class;
        public string Family_name;
        public string First_name;
        public string Middle_name;

        public DataTrainess(DataRow row)
        {
            idTrainess = Convert.ToInt32(row["idTrainess"]);
            Class = Convert.ToInt32(row["class"]);
            Family_name = Convert.ToString(row["family_name"]);
            First_name = Convert.ToString(row["first_name"]);
            Middle_name = Convert.ToString(row["middle_name"]);
        }

        internal static void TrainessAdd()
        {
            throw new NotImplementedException();
        }

        public static List<DataTrainess> Select()
        {
            List<DataTrainess> listTrainess = new List<DataTrainess>();
            DataTable data = BDConnection.Select("SELECT * FROM trainesses;");
            foreach (DataRow row in data.Rows)
            {
                listTrainess.Add(new DataTrainess(row));
            }
            return listTrainess;
        }

        public void Delete()
        {
            BDConnection.Select("DELETE FROM biblioteka.Trainesses WHERE(`id_20 - 21_kl` = '13')");
        }

        public static void TrainessAdd(int Class, string Family_name, string First_name, string Middle_name)
        {
            BDConnection.Select("INSERT INTO trainesses (`class`, `family_name`, `first_name`, `middle_name`) " +
                "VALUES ('"+ Class +"', '"+ Family_name +"', '"+ First_name +"', '"+ Middle_name +"');");
        }
    } 
}
