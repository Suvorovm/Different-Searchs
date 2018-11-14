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
        /// <summary>
        /// Метод сортировки путем прямого обмена
        /// </summary>
        /// <param name="array">Сортируемый массив</param>
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
        /// <summary>
        /// для работы с интрефесом.Прямой обмен.
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dataGridView">Таблица</param>
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
        /// <summary>
        /// Метод сортировки путем прямого включения
        /// </summary>
        /// <param name="array">Сортируемый массив</param>
        public void DirectInclude(int[] array)
        {
            int index = 0;
            int value = 0;
            for (int i = 1; i < array.Length; i++)
            {
                index = i;
                value = array[i];
                while ((index>0)&& (value<array[index-1]))
                {
                    array[index] = array[index - 1];
                    index--;
                }
                array[index] = value;// после выполнения сдвига, ставится за эллемент
            }
        }
        /// <summary>
        /// Метод сортировки путем прямого включения.Сортировка для работы с интерфесом
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dataGridView">Таблица</param>
        public void DirectInclude(int[] array, DataGridView dataGridView)
        {
            int index = 0;
            int barier = 0;//барьер
            int numOfcell = 1;
            for (int i = 1; i < array.Length; i++)
            {
                index = i;
                barier = array[i];
                while ((index > 0) && (barier < array[index - 1]))
                {
                    array[index] = array[index - 1];
                    index--;
                }
                AddTotabel(dataGridView,array, numOfcell);
                numOfcell++;
                array[index] = barier;// после выполнения сдвига, ставится за эллемент
            }
        }



    }
}
