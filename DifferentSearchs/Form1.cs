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
            dataGridView1[0, 0].Value = "0";


        }

        private void buttonSortDirectExchange_Click(object sender, EventArgs e)
        {
            int[] array = new int[10];
            for (int i = 1; i < array.Length+1; i++)
            {
                array[i - 1] = Int32.Parse(dataGridView1[i, 0].Value.ToString());
            }
            searchsAlgorithms.DirectExchange(array, dataGridView1);
        }
    }
}
