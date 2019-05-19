using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RyougiGRandomSystem
{
    class CSVReader
    {
        public CSVReader()
        {

        }
        public List<List<string>> ReadFromFileToList(string filepath)
        {
            List<List<string>> result=new List<List<string>>();
            string[] source = File.ReadAllLines(filepath);
            int i = 0;
            foreach(string rows in source)
            {
                string[] cells = rows.Split(',');
//              MessageBox.Show(Convert.ToString(cells.Length));
                result.Add(new List<string>());
                foreach(string cell in cells)
                {
                    result[i].Add(cell);
                }
                i++;
            }
            return result;
        }

    }
}
