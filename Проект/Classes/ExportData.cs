using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект.Classes
{
    class ExportData
    {
        public static bool ExportExcel(string filename, string sheetname, string[,] values)
        {
            try
            {
                FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write);
                XSSFWorkbook workbook = new XSSFWorkbook();
                ISheet sheet = workbook.CreateSheet(sheetname);

                for (int r = 0; r < values.GetLength(0); r++)
                {
                    IRow row = sheet.CreateRow(r);
                    for (int c = 0; c < values.GetLength(1); c++)
                    {
                        row.CreateCell(c).SetCellValue(values[r, c]);
                    }
                }
                workbook.Write(file);
                workbook.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
