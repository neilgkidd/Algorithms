using System;
using Xunit;

namespace AlgoTests
{
    public class PalindromeTests
    {
        [Fact]
        public void Test4DigitPalindrome_CentralIndex()
        {
            var inputText = "bobob";
            int charIndex = GetIndexToCreatePalindrome(inputText);
            Assert.Equal(2, charIndex);
        }

        [Fact]
        public void Test4DigitPalindrome_EndIndex()
        {
            var inputText = "boobs";
            int charIndex = GetIndexToCreatePalindrome(inputText);
            Assert.Equal(4, charIndex);
        }

        [Fact]
        public void Test3DigitPalindrome_CentralIndex()
        {
            var inputText = "abca";
            int charIndex = GetIndexToCreatePalindrome(inputText);
            Assert.Equal(2, charIndex);
        }

        private int GetIndexToCreatePalindrome(string inputText)
        {
            int start = 0;
            int end = inputText.Length - 1;

            while (end >= start)
            {
                if (end == start)
                {
                    return start;
                }
                else if (inputText[start] == inputText[end])
                {
                    start++;
                    end--;
                }
                else if (start + 1 == end)
                {
                    return end;
                }
                else if (inputText[start+1] == inputText[end])
                {
                    return start;
                }
                else if (inputText[start] == inputText[end-1])
                {
                    return end;
                }
            }

            return -1;
        }
    }
}
