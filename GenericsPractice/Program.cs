using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericsPractice
{
    class Program
    {

        static void Main(string[] args)
        {
            // Duplicates: 10, 30, 40, 50
            List<int> firstList = new List<int> { 10, 30, 40, 20, 10, 40, 50, 50, 60, 100, 30};

            // Expected Result: 10, 30, 40, 20, 50, 60, 100
            List<int> newList = RemoveListDuplicates(firstList);

            foreach (int item in newList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        // Remove duplicates from a outputList in one line using Linq
        //public static List<T> RemoveListDuplicates<T>(List<T> outputList) => outputList.Distinct().ToList();

        public static List<T> RemoveListDuplicates<T>(List<T> inputList)
        {
            List<T> outputList = new List<T>();
            
            if (inputList.Count > 0)
            {
               outputList.Add(inputList[0]);

                foreach (T inputItem in inputList)
                {
                    foreach (T outputItem in outputList)
                    {
                        if (!outputList.Contains(inputItem))
                        {
                            outputList.Add(inputItem);
                            break;
                        }
                    }
                }

            }

            return outputList;
        }

    }
}
