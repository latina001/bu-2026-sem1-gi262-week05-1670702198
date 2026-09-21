using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture
        public int[] LCT01_SelectionSortAscending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                (numbers[i], numbers[minIndex]) = (numbers[minIndex], numbers[i]);
            }
            return numbers;
        }

        public int[] LCT02_BubbleSortAscending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
            for (int j= 0;j < numbers.Length-i-1; j++)
                {
                    if (numbers[j] > numbers[j + 1]) 
                    {
                        (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                    }
                }
            } 
            return numbers;
        }

        public int[] LCT03_InsertionSortAscending(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            { 
            int key = numbers[i];
                int j = i - 1;
                while (numbers[j] > key && j >= 0)
                {
                    numbers[j+1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = key;

            }
            return numbers;
        }

        #endregion

        #region Assignment

        public int[] AS01_SelectionSortDescending(int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers));
            }

            
            int[] arr = (int[])numbers.Clone();

           
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int maxIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[maxIndex])
                    {
                        maxIndex = j;
                    }
                }

                if (maxIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[maxIndex];
                    arr[maxIndex] = temp;
                }
            }

           
            foreach (int n in arr)
            {
                Console.WriteLine(n);
            }

           
            return arr;
        }

        public int[] AS02_BubbleSortDescending(int[] numbers)
        {
          
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers));
            }

            
            int[] arr = (int[])numbers.Clone();

          
            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] < arr[j + 1])   
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                
                if (!swapped)
                {
                    break;
                }
            }

       
            foreach (int n in arr)
            {
                Console.WriteLine(n);   
            }

           
            return arr;
        }

        public int[] AS03_InsertionSortDescending(int[] numbers)
        {
           
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers));
            }

         
            int[] arr = (int[])numbers.Clone();

           
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

              
                while (j >= 0 && arr[j] < key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                
                arr[j + 1] = key;
            }

            
            foreach (int n in arr)
            {
                Console.WriteLine(n);
            }

           
            return arr;
        }

        public int AS04_FindTheSecondLargestNumber(int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers));
            }
            if (numbers.Length < 2)
            {
                throw new InvalidOperationException("ต้องมีสมาชิกอย่างน้อย 2 ตัว");
            }

            
            int[] arr = (int[])numbers.Clone();
            Array.Sort(arr);
            Array.Reverse(arr);

            
            int largest = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < largest)
                {
                    Console.WriteLine(arr[i]);   
                    return arr[i];
                }
            }

            
            throw new InvalidOperationException("ไม่มีค่าที่มากเป็นอันดับสอง (ทุกตัวเท่ากัน)");
        }

        #endregion

        #region Extra

        public int EX01_FindLongestConsecutiveSequence(int[] numbers)
        {
           
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers));
            }

            if (numbers.Length == 0)
            {
                Console.WriteLine("The longest consecutive sequence is: 0");
                return 0;
            }

          
            int[] arr = (int[])numbers.Clone();
            Array.Sort(arr);

           
            int current = 1;
            int longest = 1;

          
            for (int i = 1; i < arr.Length; i++)
            {
                long diff = (long)arr[i] - arr[i - 1];   

                if (diff == 1)
                {
                    current++;
                    if (current > longest)
                    {
                        longest = current;
                    }
                }
                else if (diff > 1)
                {
                    current = 1;               
                }
               
            }

         
            Console.WriteLine($"The longest consecutive sequence is: {longest}");  

         
            return longest;
        }

        #endregion
    }
}
