using System;

namespace Exercices
{
    public class Exercice6
    {
        private int[] arr;

        private void InitArr()
        {
            int[] tab = new int[50];
            Random random = new Random();
            for (int i = 0; i < 100; i+=2)
            {
                tab[i / 2] = i;
            }

            arr = tab;
        }

        public bool Dicho(int element)
        {
            InitArr();
            int min = 0;
            int max = arr.Length-1;
            int mid;
            if (element > arr[max] || element < arr[min])
            {
                return false;
            }
            else
            {
                while (min <= max)
                {
                    mid = (min + max) / 2;
                    if (element == arr[mid])
                    {
                        return true;
                    }
                    else if (arr[mid] < element)
                    {
                        min = mid + 1;
                    }
                    else
                    {
                        max = mid - 1;
                    }
                }
                return false;
              
            } 
        }
        
    }
}