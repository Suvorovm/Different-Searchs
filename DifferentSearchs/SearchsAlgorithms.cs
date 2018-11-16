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
        /// /// <param name="countCompare">Счетчик сравнения</param>
        /// /// <param name="countChang">Счетчик перестановок</param>
        public void  DirectExchange(int[] array,ref long countCompare, ref long countChang )
     {
            bool flag = true;
            int counter = 1;
            int temrory = 0;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < array.Length-counter; i++)
                {
                    countCompare++;
                    if (array[i] > array[i + 1])
                    {
                        temrory = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temrory;
                        flag = true;
                        countChang++;
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
        public void DirectInclude(int[] array,ref long counterOfCompare,ref long counterOfChanges)
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
                    counterOfChanges++;
                    counterOfCompare++;
                }
                counterOfChanges++;
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
            AddTotabel(dataGridView, array, numOfcell);
        }


        /// <summary>
        /// Сортировка путем прямого выбора
        /// </summary>
        /// <param name="array">Сортируемый массив</param>
        public void DirectChange(int[] array,ref long countertOfCompar,ref long counterOfChange)
        {
            if(array.Length == 0)
            {
                throw new ArgumentException();
            }
            int needToLook = array.Length-1;
            int max = array[0];
            int indexMax = 0;
            int temprory = 0;
            while(needToLook > 0)
            {
                for (int i = 0; i <= needToLook; i++)
                {
                    countertOfCompar++;
                    if (max < array[i])
                    {
                        max = array[i];
                        indexMax = i;
                    }                                            
                }
                
                temprory = array[needToLook];
                array[needToLook] = array[indexMax];
                array[indexMax] = temprory;
                needToLook--;
                max = array[needToLook];
                counterOfChange++;
            }

        }

        /// <summary>
        /// Сортировка путем прямого выбора. С интерфейсом
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dataGridView">таблица</param>
        public void DirectChange(int[] array, DataGridView dataGridView)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException();
            }
            int cell= 1;
            int needToLook = array.Length - 1;
            int max = array[0];
            int indexMax = 0;
            int temprory = 0;
            while (needToLook > 0)
            {
                for (int i = 0; i <= needToLook; i++)
                {
                    if (max < array[i])
                    {
                        max = array[i];
                        indexMax = i;
                    }
                }

                temprory = array[needToLook];
                array[needToLook] = array[indexMax];
                array[indexMax] = temprory;
                needToLook--;
                max = array[needToLook];
                AddTotabel(dataGridView, array, cell);
            }

        }
        /// <summary>
        /// Сортировка Шелла.
        /// </summary>
        /// <param name="array">Сортируемый массив</param>
        public void SortingByShell(int[] array,ref long countCompar,ref long countOfChanges)
        {
           
            int temrory,j= 0;
       
            int d = array.Length/2;
            while(d>0)
            {
                for (int i = 0; i < array.Length - d; i++)
                {
                    j = i;
                    while (j >= 0 && array[j] > array[j + d])
                    {
                        temrory = array[j];
                        array[j] = array[j + d];
                        array[j + d] = temrory;
                        j--;
                        countOfChanges++;
                        countCompar++;
                    }
                    countCompar++;
                }
                d = d  / 2;
            }
        }
        /// <summary>
        /// Сортировка Шелла.С интерфесом
        /// </summary>
        /// <param name="array"></param>
        /// <param name="dataGridView">Таблица</param>
        public void SortingByShell(int[] array,DataGridView dataGridView)
        {
        
            int  temrory, j = 0;
            int countOfcell = 1;
            int d = array.Length / 3;
            while (d > 0)
            {
                for (int i = 0; i < array.Length - d; i++)
                {
                    j = i;
                    while (j >= 0 && array[j] > array[j + d])
                    {
                        temrory = array[j];
                        array[j] = array[j + d];
                        array[j + d] = temrory;
                        j--;
                    }
                }
                AddTotabel(dataGridView, array, countOfcell);
                countOfcell++;
                d = d / 3;
            }
        }
        /// <summary>
        /// Линейная сортировка
        /// </summary>
        /// <param name="array">Сортируемый массив. Значения не больше 100</param>
        public void LineSorting(int[] array)
        {
            const int barear = 101;
            int[] helpArray = new int[100];
            for (int i = 0; i < helpArray.Length; i++)
            {
                helpArray[i] = 101;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > barear)
                {
                    throw new ArgumentException();
                }
                else
                {
                    if (helpArray[array[i]] == barear)
                    {
                        helpArray[array[i]] = 1;

                    }
                    else
                    {
                        helpArray[array[i]] += 1;
                    }
                }
            }
            int counter = 0;
            int countOfciclus = 0;
            for (int i = 0; i < helpArray.Length; i++)
            {
                if (helpArray[i] != barear)
                {
                    countOfciclus = helpArray[i];
                    while (countOfciclus > 0)
                    {
                        array[counter] = i;
                        counter++;
                        countOfciclus--;
                    }
                }
            }
        }

    }
}
