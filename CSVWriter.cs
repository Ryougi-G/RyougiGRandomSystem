using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RyougiGRandomSystem
{
    class CSVWriter
    {
        public void WriteListToFile(List<List<string>> table,string filepath)
        {
            StreamWriter writer = new StreamWriter(filepath, false,Encoding.Default);
            foreach(List<string> row in table)
            {
                string para = "";
                for(int i = 0; i < row.Count - 1; i++)
                {
                    para += row[i];
                    para += ",";
                }
                para += row[row.Count - 1];
                writer.WriteLine(para);
            }
            writer.Dispose();
            return;
        }
    }
}
