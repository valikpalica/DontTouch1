using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marina
{
    public partial class Form6 : Form
    {
        string[] array;
        public Form6()
        {
            InitializeComponent();
            GenTable();
        }
        public void GenTable()
        {
            array = MidleList.array.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                string name = "";
                int counter = 1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] != "*")
                    {
                        name = array[i].Split('/')[5];
                        if (array[i].Split('/')[5].Equals(array[j].Split('/')[5]))
                        {
                            name = array[i].Split('/')[5];
                            array[j] = "*";
                            counter++;
                        }
                    }
                }
                if (name != "")
                {
                    dataGridView1.Rows.Add(name, counter.ToString());
                }
            }
        }
    }
}
