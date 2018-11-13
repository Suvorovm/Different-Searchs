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
        public Form1()
        {
            InitializeComponent();
            DataGridViewRow dataRow = new DataGridViewRow();
            dataRow.ReadOnly = false;
            dataGridView1.Rows.Add(dataRow);
            
        }
    }
}
