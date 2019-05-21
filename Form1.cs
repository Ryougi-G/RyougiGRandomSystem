using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RyougiGRandomSystem
{
    public partial class Form1 : Form
    {
        CSVReader reader = new CSVReader();
        List<List<string>> data;
        public Form1()
        {
            InitializeComponent();
        }
        public void AddStringsToDGV(List<List<string>> table)
        {
            for (int i = 1; i <= table[0].Count; i++)
            {
                dataGridView1.Columns.Add("", "");
            }
            foreach (List<string> row in table)
            {
                DataGridViewRow viewRow = new DataGridViewRow();
                //dataGridView1.Rows[dataGridView1.Rows.Count - 1];
                foreach (string cell in row)
                {
                    DataGridViewTextBoxCell data = new DataGridViewTextBoxCell();
                    data.Value = cell;
                    viewRow.Cells.Add(data);
                }
                dataGridView1.Rows.Add(viewRow);
            }
        }
        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            label1.Text = openFileDialog1.FileName;
            List<List<string>> table = reader.ReadFromFileToList(openFileDialog1.FileName);
            data = table;
            AddStringsToDGV(table);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            RyougiGRandom random = new RyougiGRandom();
            List<int> ranks = random.GetRandomRanks(data.Count);
            List<List<string>> result=new List<List<string>>();
            for(int i = 1; i <= data.Count; i++)
            {
                int pos = 0;
                for(int j = 0; j < ranks.Count; j++)
                {
                    if (ranks[j] == i)
                    {
                        pos = j;
                        break;
                    }
                }
                result.Add(data[pos]);
            }
            dataGridView1.Columns.Clear();
            AddStringsToDGV(result);
            data = result;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            CSVWriter writer = new CSVWriter();
            writer.WriteListToFile(data, saveFileDialog1.FileName);
        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
