using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifferentSearchs
{
    public partial class Form1 : Form
    {
        SearchsAlgorithms searchsAlgorithms;
        public Form1()
        {
            InitializeComponent();
            searchsAlgorithms = new SearchsAlgorithms();
            DataGridViewRow dataRow = new DataGridViewRow();      
            dataRow.ReadOnly = false;
            dataGridView1.Rows.Add(dataRow);
            dataGridView1[0, 0].Value = "0 проход";
                      
            DataGridViewRow dataRownclude = new DataGridViewRow();
            dataRownclude.ReadOnly = false;
            dataGridDirectInclude.Rows.Add(dataRownclude);
            dataGridDirectInclude[0, 0].Value = "0 проход";

            DataGridViewRow directChange = new DataGridViewRow();
            directChange.ReadOnly = false;
            dataGridViewDirectChange.Rows.Add(directChange);
            dataGridViewDirectChange[0, 0].Value = "0 проход";

            DataGridViewRow dataRowShell = new DataGridViewRow();
            SortingByShell.Rows.Add(dataRowShell);
            SortingByShell[0, 0].Value = "0 проход";
        }

        private void buttonSortDirectExchange_Click(object sender, EventArgs e)
        {
            int[] array = new int[10];


            for (int i = 1; i < array.Length + 1; i++)
            {
                array[i - 1] = Int32.Parse(dataGridView1[i, 0].Value.ToString());
            }
            dataGridView1.Rows.Clear();
            DataGridViewRow dataRow = new DataGridViewRow();                     
            dataGridView1.Rows.Add(dataRow);
            dataGridView1[0, 0].Value = "0 проход";
            for (int i = 1; i <array.Length+1; i++)
            {
                dataGridView1[i, 0].Value = array[i - 1];
            }
            dataGridView1.Refresh();
            searchsAlgorithms.DirectExchange(array, dataGridView1);
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            int[] array = new int[10];

            for (int i = 1; i < array.Length+1; i++)
            {
                array[i - 1] = Int32.Parse(dataGridDirectInclude[i, 0].Value.ToString());
            }
            dataGridDirectInclude.Rows.Clear();
            DataGridViewRow data = new DataGridViewRow();
            dataGridDirectInclude.Rows.Add(data);
            dataGridDirectInclude[0, 0].Value = "0 проход";
            for (int i = 1; i < array.Length + 1; i++)
            {
                dataGridDirectInclude[i, 0].Value = array[i - 1];
            }
            dataGridDirectInclude.Refresh();
            searchsAlgorithms.DirectInclude(array, dataGridDirectInclude);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] array = new int[10];

            for (int i = 1; i < array.Length + 1; i++)
            {
                array[i - 1] = Int32.Parse(dataGridViewDirectChange[i, 0].Value.ToString());
            }
            dataGridViewDirectChange.Rows.Clear();
            DataGridViewRow data = new DataGridViewRow();
            dataGridViewDirectChange.Rows.Add(data);
            dataGridViewDirectChange[0, 0].Value = "0 проход";
            for (int i = 1; i < array.Length + 1; i++)
            {
                dataGridViewDirectChange[i, 0].Value = array[i - 1];
            }
            dataGridViewDirectChange.Refresh();
            searchsAlgorithms.DirectInclude(array, dataGridViewDirectChange);
        }

        private void buttonShell_Click(object sender, EventArgs e)
        {
            int[] array = new int[20];
            for (int i = 1; i < array.Length; i++)
            {
                array[i - 1] = Int32.Parse(SortingByShell[i, 0].Value.ToString());
            }
            SortingByShell.Rows.Clear();
            DataGridViewRow data = new DataGridViewRow();
            SortingByShell.Rows.Add(data);
            SortingByShell[0, 0].Value = "0 проход";
            for (int i = 1; i < array.Length + 1; i++)
            {
                SortingByShell[i, 0].Value = array[i - 1];
            }
            SortingByShell.Refresh();
            searchsAlgorithms.DirectInclude(array, SortingByShell);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var stopWatch = new Stopwatch();
            int count = (int)numericUpDown1.Value;
            int[] array = new int[count];
            int[] coppyOfArray = new int[count];
            var rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                array[i] = rnd.Next(0, 100);
            }
            long counterCompare = 0;
            long counterExchange = 0;
            Array.Copy(array, coppyOfArray,count);
            stopWatch.Start();
            searchsAlgorithms.DirectExchange(coppyOfArray, ref counterCompare, ref counterExchange);
            stopWatch.Stop();
            textBox1.Text = counterCompare.ToString();
            textBox2.Text = counterExchange.ToString();
            textBox3.Text = stopWatch.Elapsed.Ticks.ToString();

            counterCompare = 0;
            counterExchange = 0;
            Array.Copy(array, coppyOfArray, count);
            stopWatch.Restart();
            searchsAlgorithms.DirectChange(coppyOfArray,ref counterCompare,ref counterExchange);
            stopWatch.Stop();
            textBox4.Text = counterCompare.ToString();
            textBox5.Text = counterExchange.ToString();
            textBox6.Text = stopWatch.Elapsed.Ticks.ToString();
        }
    }
}
