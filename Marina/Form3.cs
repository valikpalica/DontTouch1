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
    public partial class Form3 : Form
    {
        string[] array;
        public Form3()
        {
            InitializeComponent();
            GenTable();
        }
        public void GenTable()
        {
            SortArray();
            for (int i = 0; i < array.Length; i++)
            {
                dataGridView1.Rows.Add(array[i].Split('/')[5], array[i].Split('/')[2], array[i].Split('/')[1]);
            }
        }
        public void SortArray()
        {
            array = MidleList.array.ToArray();
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (EqualsChar(array[i].Split('/')[5].ToLower(), array[j].Split('/')[5].ToLower()))
                    {
                        string s = array[i];
                        array[i] = array[j];
                        array[j] = s;
                    }
                }
            }
        }
        public bool EqualsChar(string s1, string s2)
        {
            for (int i = 0; i < (s1.Length > s2.Length ? s2.Length : s1.Length); i++)
            {
                if (s1.ToCharArray()[i] < s2.ToCharArray()[i]) return false;
                if (s1.ToCharArray()[i] > s2.ToCharArray()[i]) return true;
            }
            return false;
        }


    }
}
