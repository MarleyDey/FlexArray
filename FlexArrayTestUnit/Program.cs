using System;
using System.Collections;
using System.Linq;
using FlexArray;


namespace FlexArrayTestUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test methods here
            FillArrayTest();

            ReplaceArrayTest();

            ReplaceAllArrayTest();
        }

        /**
         * <summary>
         *  This will run a test for filling an
         *  array of a single value and type.
         * </summary>
         */
        static void FillArrayTest()
        {
            var testArray = new int[10];
            testArray.Fill(5);
            PrintArray(testArray);

            testArray.Fill("Test");
            PrintArray(testArray);

            testArray.Fill(2.5);
            PrintArray(testArray);
        }

        /**
         * <summary>
         *  This will run a test for replacing the
         *  first matching value and replace it with
         *  the second defined value.
         * </summary>
         */
        static void ReplaceArrayTest()
        {
            var testArray = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            testArray.Replace(4, 12);
            PrintArray(testArray);

            testArray.Replace(4, 11);
            PrintArray(testArray);

            var testArray2 = new int[] { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4};
            testArray2.Replace("check", "test");
            PrintArray(testArray);

            testArray2.Replace(4, 6);
            PrintArray(testArray);
        }

        /**
         * <summary>
         *  This will run a test for replacing the
         *  all matching value and replacing with
         *  the second defined value.
         * </summary>
         */
        static void ReplaceAllArrayTest()
        {
            var testArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            testArray.ReplaceAll(4, 12);
            PrintArray(testArray);

            testArray.ReplaceAll(4, 11);
            PrintArray(testArray);

            var testArray2 = new int[] { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4};
            testArray2.Replace("check", "test");
            PrintArray(testArray);

            testArray2.ReplaceAll(4, 6);
            PrintArray(testArray);
        }

        /**
         * <summary>
         *  This will print the array out to the console
         *  in a single line, enumerating over the array.
         *
         *  <param name="array">Array to print out</param>
         * </summary>
         */
        static void PrintArray<TArray>(TArray array)
        {
            Console.Write("[");
            foreach (var value in (IEnumerable) array)
            {
                Console.Write("" + value + ",");
                
            }

            Console.Write("]\n");
        }
    }
}
