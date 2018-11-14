using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
