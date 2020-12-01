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
    public partial class Form4 : Form
    {
        public int countDSK = 0;
        public int countNoSicret = 0;
        public int countSicret = 0;
        string[] array;
        public Form4()
        {
            InitializeComponent();
            Status();
            GenTable();
        }
        public void GenTable()
        {
            dataGridView1.Rows.Add("ДСК",countDSK);
            dataGridView1.Rows.Add("Таємно", countSicret);
            dataGridView1.Rows.Add("Не таємно", countNoSicret);
        }
        public void Status() {
            array = MidleList.array.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                switch (array[i].Split('/')[3])
                {
                    case "ДСК":
                        countDSK++;
                        break;
                    case "Таємно":
                        countSicret++;
                        break;
                    case "Не таємно":
                        countNoSicret++;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
