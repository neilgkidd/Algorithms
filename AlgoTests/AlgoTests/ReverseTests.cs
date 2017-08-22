using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;

namespace AlgoTests
{
    public class ReverseTests
    {
        [Fact]
        public void SimpleStringTest()
        {
            var inputText = "hello";
            var resultText = ReverseString(inputText);
            Assert.Equal("olleh", resultText);
        }

        [Fact]
        public void StringWithSpacesTest()
        {
            var inputText = "hello world";
            var resultText = ReverseString(inputText);
            Assert.Equal("dlrow olleh", resultText);
        }

        [Fact]
        public void SimpleStringTest_Builder()
        {
            var inputText = "hello";
            var resultText = ReverseStringBuilder(inputText);
            Assert.Equal("olleh", resultText);
        }

        [Fact]
        public void StringWithSpacesTest_Builder()
        {
            var inputText = "hello world";
            var resultText = ReverseStringBuilder(inputText);
            Assert.Equal("dlrow olleh", resultText);
        }

        [Fact]
        public void SimpleStringTest_Array()
        {
            var inputText = "hello";
            var resultText = ReverseStringArray(inputText);
            Assert.Equal("olleh", resultText);
        }

        [Fact]
        public void StringWithSpacesTest_Array()
        {
            var inputText = "hello world";
            var resultText = ReverseStringArray(inputText);
            Assert.Equal("dlrow olleh", resultText);
        }

        [Fact]
        public void SimpleStringTest_LINQ()
        {
            var inputText = "hello";
            var resultText = ReverseStringArrayLinq(inputText);
            Assert.Equal("olleh", resultText);
        }

        [Fact]
        public void StringWithSpacesTest_LINQ()
        {
            var inputText = "hello world";
            var resultText = ReverseStringArrayLinq(inputText);
            Assert.Equal("dlrow olleh", resultText);
        }

        [Fact]
        public void SimpleStringTest_ExtensionMethod()
        {
            var inputText = "hello";
            var resultText = ReverseStringExtension(inputText);
            Assert.Equal("olleh", resultText);
        }

        [Fact]
        public void StringWithSpacesTest_ExtensionMethod()
        {
            var inputText = "hello world";
            var resultText = ReverseStringExtension(inputText);
            Assert.Equal("dlrow olleh", resultText);
        }

        [Fact]
        public void SimpleStringTest_NonLinear()
        {
            var inputText = "hello";
            var resultText = ReverseStringNonLinear(inputText);
            Assert.Equal("olleh", resultText);
        }

        [Fact]
        public void StringWithSpacesTest_NonLinear()
        {
            var inputText = "hello world";
            var resultText = ReverseStringNonLinear(inputText);
            Assert.Equal("dlrow olleh", resultText);
        }

        [Fact]
        public void SimpleStringTest_Recursive()
        {
            var inputText = "hello";
            var resultText = ReverseStringRecursive(inputText.ToCharArray());
            Assert.Equal("olleh", resultText);
        }

        [Fact]
        public void StringWithSpacesTest_Recursive()
        {
            var inputText = "hello world";
            var resultText = ReverseStringRecursive(inputText.ToCharArray());
            Assert.Equal("dlrow olleh", resultText);
        }

        private string ReverseString(string inputText)
        {
            var inputChars = inputText.ToCharArray();
            string retString = string.Empty;

            for (int i = inputChars.Length - 1; i >= 0; i--)
            {
                retString += inputChars[i];
            }

            return retString;
        }

        private string ReverseStringBuilder(string inputText)
        {
            var inputChars = inputText.ToCharArray();
            StringBuilder sb = new StringBuilder();

            for (int i = inputChars.Length - 1; i >= 0; i--)
            {
                sb.Append(inputChars[i]);
            }

            return sb.ToString();
        }

        private string ReverseStringArray(string inputText)
        {
            var inputChars = inputText.ToCharArray();
            Array.Reverse(inputChars);
            return new string(inputChars);
        }

        private string ReverseStringArrayLinq(string inputText)
        {
            return new string(inputText.ToCharArray().Reverse().ToArray());
        }

        private string ReverseStringExtension(string inputText)
        {
            return inputText.Reverse();
        }

        private string ReverseStringNonLinear(string inputText)
        {
            var inputChars = inputText.ToCharArray();
            int start = 0;
            int end = inputChars.Length - 1;
            char tempChar;

            while (start < end)
            {
                tempChar = inputChars[start];
                inputChars[start] = inputChars[end];
                inputChars[end] = tempChar;
                start++;
                end--;
            }

            return new string(inputChars);
        }

        private string ReverseStringRecursive(char[] inputChars, int start = 0, int end = 0)
        {
            if (end == 0)
                end = inputChars.Length - 1;

            if (start < end)
            {
                char tempChar = inputChars[start];
                inputChars[start] = inputChars[end];
                inputChars[end] = tempChar;
                start++;
                end--;
                ReverseStringRecursive(inputChars, start, end);
            }

            return new string(inputChars);
        }
    }

    static class StringExtensions
    {
        public static string Reverse(this string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray());
        }
    }
}
