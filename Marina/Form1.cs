using Microsoft.VisualBasic;
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
    public partial class Form1 : Form
    {
        public string[] array = new string[] {
        "1/22.11.2020/№4373216712/ДСК/Ткаченко/Богуцкий",
        "2/20.12.2020/№4342412442/Не таємно/Шкицкий/Стоцкий",
        "3/21.11.2020/№4345634563/Таємно/Власенко/Редзюк",
        "4/22.11.2020/№5234523454/Не таємно/Палиця/Шкорупский",
        "5/22.11.2020/№5237237524/Таємно/Циганок/Власюк",
        "6/20.12.2020/№6813465628/ДСК/Головко/Антонюк",
        "7/21.11.2020/№7263495239/Не таємно/Грохольский/Вінницкий",
        "8/22.11.2020/№7236475673/Таємно/Жильцов/Пархоменко",
        "9/22.11.2020/№7324952365/ДСК/Юшко/Ковалик",
        "10/20.12.2020/№6582346856/Таємно/Борблик/Нечаев",
        "11/22.11.2020/№43456325463/Таємно/Власенко/Редзюк",
        "12/20.12.2020/№68134651238/ДСК/Головко/Антонюк"
        };    
        public Form1()
        {
            InitializeComponent();
            GenerateList();
        }
        public void GenerateList() {
            GenerateTable();
        }
        public void GenerateTable() {
            for (int i = 0; i < array.Length; i++)
            {
                dataGridView1.Rows.Add(array[i].Split('/')[0], array[i].Split('/')[1], array[i].Split('/')[2], array[i].Split('/')[3], array[i].Split('/')[4], array[i].Split('/')[5]);
            }
        }

        private void відправникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MidleList.array = array;
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void отримувачToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MidleList.array = array;
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void списокВидівДокументівТаЇхКількостіПоВидахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MidleList.array = array;
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void кількістьОпераційЗДокументамиПоДатахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MidleList.array = array;
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void сумарнаКількістьОтриманихДокументівПоОтримувачахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MidleList.array = array;
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = Interaction.InputBox("Новий id", "Додавання id", "", 200, 300);
            string number = Interaction.InputBox("Новий номер документу", "Додавання докумету", "", 200, 300);
            string secret = Interaction.InputBox("Рівень секретності", "", "", 200, 300);
            string response = Interaction.InputBox("Відправник", "Відправник", "", 200, 300);
            string request = Interaction.InputBox("Отримувач", "Отримувач", "", 200, 300);
            DateTime date = new DateTime();
            string result = $"{id.Trim()}/${date.ToString().Split(' ')[0]}/№{number.Trim()}/{secret.Trim()}/{response.Trim()}/${request.Trim()}";
            AddInArray(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string content = Interaction.InputBox("Виберіть id", "Видалення", "", 200, 300);
            for (int i = 0; i < array.Length; i++)
            {
                if (content.Equals(array[i].Split('/')[0]))
                {
                    Remove(array[i], i);
                }
            }
        }
        public void RefreshTable()
        {
            this.dataGridView1.Rows.Clear();
            Sort();
            GenerateTable();
        }
        public void AddInArray(string input)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = input;
            RefreshTable();
        }
        public void Remove(string input, int index)
        {
            string last = array[array.Length - 1];
            array[array.Length - 1] = input;
            array[index] = last;
            Array.Resize(ref array, array.Length - 1);
            RefreshTable();
        }
        public void Sort()
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (int.Parse(array[i].Split('/')[0]) > int.Parse(array[j].Split('/')[0]))
                    {
                        string temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;

                    }
                }
            }
        }
    }
}
