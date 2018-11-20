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
        public (int countCompare, int countChang)  DirectExchange(int[] array )
     {
            int countCompare = 0;
            int countChang = 0;
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
            return (countCompare, countChang);
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
        public (int countCompare, int countChang) DirectInclude(int[] array)
        {
            int countCompare = 0;
            int countChang = 0;
            int index = 0;
            int value = 0;
            
            for (int i = 2; i < array.Length; i++)
            {
                index = i;
                array[0] = array[i];
                while ((index > 0) && (array[0] < array[index - 1]))
                {
                    array[index] = array[index - 1];
                    index--;
                    countCompare++;
                    countChang++;
                }
                countChang++;
                array[index] = array[0];// ;// после выполнения сдвига, ставится за эллемент
            }
            return (countCompare, countChang);
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
            int[] copyArray = new int[10];
            for (int i = 2; i < array.Length; i++)
            {

                index = i;
                array[0] = array[i];
                while ((index > 0) && (array[0] < array[index - 1]))
                {
                    array[index] = array[index - 1];
                    index--;
                }                              
               
                array[index] = array[0];
                Array.Copy(array, 1, copyArray, 0, copyArray.Length);
                AddTotabel(dataGridView, copyArray, numOfcell);
                numOfcell++;
            }
          
           
        }


        /// <summary>
        /// Сортировка путем прямого выбора
        /// </summary>
        /// <param name="array">Сортируемый массив</param>
        public (int countCompare, int countChang) DirectChange(int[] array)
        {
            int countertOfCompar = 0;
            int counterOfChange = 0;
            if (array.Length == 0)
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
                indexMax = 0;
                max = array[indexMax];
                counterOfChange++;
            }
            return (countertOfCompar, counterOfChange);
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
            int cell = 1;
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
                AddTotabel(dataGridView, array, cell);
                needToLook--;
                cell++;
                indexMax = 0;
                max = array[indexMax];               
            }

        }
        /// <summary>
        /// Сортировка Шелла.
        /// </summary>
        /// <param name="array">Сортируемый массив</param>
        public (long compare, long changes) SortingByShell(int[] array)
        {
            int counterCompare = 0;
            int counterChenges = 0;
            int t = (int)Math.Floor(Math.Log(array.Length) / Math.Log(2)) - 1;
            int step = 1;
            for (int i = 0; i <= t; i++)
            {
                step = 2 * step + 1;
            }
            while (step > 0)
            {
                int i, j;
                for (i = step; i < array.Length; i++)
                {
                    int value = array[i];
                    for (j = i - step; (j >= 0) && (array[j] > value); j -= step)
                    {
                        array[j + step] = array[j];
                        counterCompare++;
                        counterChenges++;
                    }
                    counterCompare++;
                    array[j + step] = value;
                }
                step /= 2;
                counterCompare++;
            }
            return (counterCompare, counterChenges);
        }
        /// <summary>
        /// Сортировка Шелла.С интерфесом
        /// </summary>
        /// <param name="array"></param>
        /// <param name="dataGridView">Таблица</param>
        public void SortingByShell(int[] array,DataGridView dataGridView)
        {
            int cell = 1;
            int t = (int)Math.Floor(Math.Log(array.Length) / Math.Log(2)) - 1;
            int step = 1;
            for (int i = 0; i < t; i++)
            {
                step = 2 * step + 1;
            }
            while (step > 0)
            {
                int i, j;
                for (i = step; i < array.Length; i++)
                {
                    int value = array[i];
                    for (j = i - step; (j >= 0) && (array[j] > value); j -= step)
                        array[j + step] = array[j];
                    array[j + step] = value;
                }
                AddTotabel(dataGridView, array, cell);
                cell++;
                step /= 2;
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

        public void LineSorting(int[] array,DataGridView dataGridView)
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
            AddTotabel(dataGridView, array, 1);
        }

    }
}
