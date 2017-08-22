using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgoTests
{
    public class BubbleSortTests
    {
        [Fact]
        public void Sort5Items()
        {
            int[] inputList = { 5, 1, 4, 3, 8 };
            int[] outputList = SortListItems(inputList);
            Assert.Collection(outputList, item => Assert.Equal(1, item), 
                                            item => Assert.Equal(3, item), 
                                            item => Assert.Equal(4, item), 
                                            item => Assert.Equal(5, item), 
                                            item => Assert.Equal(8, item));
        }

        private int[] SortListItems(int[] inputList)
        {
            foreach (var num in inputList)
            {
                int item = 0;

                while (item < inputList.Length - 1)
                {
                    if (inputList[item] > inputList[item + 1])
                    {
                        var temp = inputList[item + 1];
                        inputList[item + 1] = inputList[item];
                        inputList[item] = temp;
                    }

                    item++;
                }
            }

            return inputList;
        }
    }
}
