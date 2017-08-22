using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgoTests
{
    public class BinarySearchTests
    {
        [Fact]
        public void SortedList3Test_SlowIteration()
        {
            int[] inputList = { 1, 2, 3 };
            int itemToFind = 2;
            int indexOfItem = FindIndex(inputList, itemToFind);
            Assert.Equal(1, indexOfItem);
        }

        [Fact]
        public void SortedList3Test_Recursive()
        {
            int[] inputList = { 1, 2, 3 };
            int itemToFind = 2;
            int indexOfItem = FindIndexRecursive(inputList, itemToFind, 0, inputList.Length -1);
            Assert.Equal(1, indexOfItem);
        }

        [Fact]
        public void SortedList4Test_Recursive()
        {
            int[] inputList = { 1, 2, 3, 4 };
            int itemToFind = 3;
            int indexOfItem = FindIndexRecursive(inputList, itemToFind, 0, inputList.Length - 1);
            Assert.Equal(2, indexOfItem);
        }

        [Fact]
        public void SortedList7Test_Recursive()
        {
            int[] inputList = { 1, 2, 3, 4, 4, 5, 6 };
            int itemToFind = 5;
            int indexOfItem = FindIndexRecursive(inputList, itemToFind, 0, inputList.Length - 1);
            Assert.Equal(5, indexOfItem);
        }

        [Fact]
        public void SortedList7Test_Loops()
        {
            int[] inputList = { 1, 2, 3, 4, 4, 5, 6 };
            int itemToFind = 5;
            int indexOfItem = FindIndexWithLoops(inputList, itemToFind, 0, inputList.Length - 1);
            Assert.Equal(5, indexOfItem);
        }

        private int FindIndexRecursive(int[] inputList, int itemToFind, int start, int end)
        {
            int midPoint = start + ((end-start) / 2);
            int retVal = midPoint;

            if (inputList[midPoint] > itemToFind)
            {
                retVal = FindIndexRecursive(inputList, itemToFind, start, midPoint);
            }
            else if (inputList[midPoint] < itemToFind)
            {
                retVal =  FindIndexRecursive(inputList, itemToFind, midPoint, end);
            }

            return retVal;
        }

        private int FindIndexWithLoops(int[] inputList, int itemToFind, int start, int end)
        {
            int retVal = -1;

            while (start < end)
            {
                int midPoint = start + ((end - start) / 2);

                if (inputList[midPoint] == itemToFind)
                {
                    retVal = midPoint;
                    break;
                }
                else if (inputList[midPoint] > itemToFind)
                {
                    end = midPoint-1;
                }
                else if (inputList[midPoint] < itemToFind)
                {
                    start = midPoint+1;
                }
            }

            return retVal;
        }

        private int FindIndex(int[] inputList, int itemToFind)
        {
            for (int i = 0; i < inputList.Length - 1; i++)
            {
                if (inputList[i] == itemToFind)
                    return i;
            }

            return -1;
        }
    }
}
