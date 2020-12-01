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
    public partial class Form5 : Form
    {
        string[] array;
        public Form5()
        {
            InitializeComponent();
            CreateList();
        }
        public void CreateList()
        {
            array = MidleList.array.ToArray();
            for(int i = 0; i < array.Length; i++)
            {
                string date = "";
                int counter = 1;
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] != "*")
                    { 
                        if (array[i].Split('/')[1].Equals(array[j].Split('/')[1]))
                        {
                            date = array[i].Split('/')[1];
                            array[j] = "*";
                            counter++;
                        } 
                    }
                }
                if (date != "")
                {
                    dataGridView1.Rows.Add(date, counter.ToString());
                }
            }
        }

    }
}
