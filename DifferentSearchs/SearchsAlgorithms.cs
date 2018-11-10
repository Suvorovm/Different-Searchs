using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentSearchs
{
    public class SearchsAlgorithms
    {
      public void  DirectSelection(int[] array)
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

    }
}
