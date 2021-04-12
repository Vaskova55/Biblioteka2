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

        public static List<DataTrainess> Select(string Search)
        {

            List<DataTrainess> listTrainess = new List<DataTrainess>();
            DataTable data = BDConnection.Select("SELECT * FROM trainesses WHERE Family_name LIKE '%"+Search+"%';");
            foreach (DataRow row in data.Rows)
            {
                listTrainess.Add(new DataTrainess(row));
            }
            return listTrainess;
        }

        public void Delete()
        {
            BDConnection.Select("DELETE FROM trainesses WHERE(`idTrainess` = '"+ idTrainess + "')");
        }

        public static void TrainessAdd(int Class, string Family_name, string First_name, string Middle_name)
        {
            BDConnection.Select("INSERT INTO trainesses (`class`, `family_name`, `first_name`, `middle_name`) " +
                "VALUES ('"+ Class +"', '"+ Family_name +"', '"+ First_name +"', '"+ Middle_name +"');");
        }

        public void TrainessEdit(int Class, string Family_name, string First_name, string Middle_name)
        {
            BDConnection.Select("UPDATE `trainesses` SET `class` = '" + Class + "'," +
                " `family_name` = '" + Family_name + "', `first_name` = '" + First_name + "', `middle_name` = '" + Middle_name + "' WHERE (`idTrainess` = '" + idTrainess + "');");
            this.Class = Class;
            this.Family_name = Family_name;
            this.First_name = First_name;
            this.Middle_name = Middle_name;
        }
    } 
}
