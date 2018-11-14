using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifferentSearchs
{
    public class SearchsAlgorithms
    {
      public void  DirectExchange(int[] array)
     {
            bool flag = true;
            int counter = 1;
            int temrory = 0;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < array.Length-counter; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temrory = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temrory;
                        flag = true;
                    }                    
                }
                counter++;
            }
       }
        /// <summary>
       /// Добавление в визуальный компонент
       /// int cell - номер строки
       /// </summary>
        private void AddTotabel(DataGridView dataGridView,int[] array,int cell)
        {
            if (cell >= dataGridView.Rows.Count)
            {
                DataGridViewRow dataRow = new DataGridViewRow();
                dataGridView.Rows.Add(dataRow);
            }
            dataGridView[0, cell].Value = cell.ToString() + " проход";           
            for (int i = 1; i < array.Length+1; i++)
            {
                dataGridView[i, cell].Value = array[i - 1];
            }
        }

        public void DirectExchange(int[] array,DataGridView dataGridView)
        {
            bool flag = true;
            int counter = 1;
            int temrory = 0;           
            while (flag)
            {               
                flag = false;
                for (int i = 0; i < array.Length - counter; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temrory = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temrory;
                        flag = true;
                    }
                }
                AddTotabel(dataGridView,array, counter);                
                counter++;
            }
        }

    }
}
