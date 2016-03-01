using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_5_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var nums2 = new List<int> { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var input1 = new List<int> { 1, 1, 1, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 9, 9, 9, 9, 9 };

            foreach (int num in GetNumbersBeetween5and10(nums1))
            { Console.Write(num + " "); }

            Console.WriteLine();

            GetMaxValue(nums1);

            Sum(nums1);

            TakeFive(nums1);

            RemoveDuplicates(nums1);

            GetCommon(nums1, nums2);

            GetDifference(nums1, nums2);

            NumberOfNumbers(input1);

            Console.ReadLine();

        }

        static List<int> GetNumbersBeetween5and10(List<int> list)
        {
            var newList = new List<int>();
            foreach (int num in list)
            {
                if (5 <= num && num <= 10) { newList.Add(num); }
            }

            return newList;
        }
        static void GetMaxValue(List<int> list)
        {
            int number = 0;
            foreach (int num in list)
            {
                if (num > number) { number = num; }
            }

            Console.WriteLine(number);
        }
        static void Sum(List<int> list)
        {
            int number = 0;
            foreach (int num in list)
            {
                number += num;
            }

            Console.WriteLine(number);
        }
        static void TakeFive(List<int> list)
        {
            int lenght = 5;
            if (list.Count < 5)
            { lenght = list.Count; }

            for ( int i=0; i < lenght; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
        static void RemoveDuplicates(List<int>list)
        {
            var newList = new List<int>();
            foreach (int num in list)
            {
                if (!newList.Contains(num)) { newList.Add(num); }
            }
            foreach (int num in newList)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

        }
        static void GetCommon(List<int> list1, List<int> list2)
        {
            foreach (int num in list1 )
            {
                if ( list2.Contains(num))
                { Console.Write(num + " "); }
            }
            Console.WriteLine();
        }
        static void GetDifference(List<int> list1, List<int> list2)
        {
            foreach (int num in list1)
            {
                if (!list2.Contains(num))
                { Console.Write(num + " "); }
            }
            Console.WriteLine();
        }
        static void NumberOfNumbers(List<int> input)
        {
            Console.WriteLine();
            var masterList = new List<int>();
            foreach (int number in input)
            {
                if (!masterList.Contains(number))
                {
                    masterList.Add(number);
                }                    
            }

            foreach (int num in masterList)
            {
                AddListAndCount(num, input);
            }
        }
        static void AddListAndCount(int num, List<int>input)
        {
            var list = new List<int>();
            foreach (int number in input)
            {
                if (number == num)
                {
                    list.Add(num);
                }
            }
            Console.Write(num + " - " + list.Count + " items");
            Console.WriteLine();

        }


    }
}
