using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_SelectionSort
{
    internal class Program
    {   
        //Implementing Selection Sort Algo for sorting array of integers
        static void Main(string[] args)
        {
            int[] array = { 1, 7, 5, 3, 7, 8 ,0,8};
            int tempNumber = 0;
            int tempNumberIndex = 0;

            for (int i = 0; i < array.Length-2; i++)
            {
                tempNumber = array[i];
                tempNumberIndex = i;
                for(int j= i+1; j < array.Length; j++)
                {
                    if (tempNumber > array[j])
                    {
                        tempNumber = array[j];
                        tempNumberIndex = j;
                    }
                            
                }

                array[tempNumberIndex] = array[i];
                array[i] = tempNumber;

            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
              
            }
            Console.ReadLine();
        }
    }
}
