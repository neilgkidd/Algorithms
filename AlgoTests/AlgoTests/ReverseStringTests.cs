using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;

namespace AlgoTests
{
    public class ReverseStringTests
    {
        [Fact]
        public void ReverseSimpleStringTest()
        {
            var inputText = "hello";
            var resultText = ReverseString(inputText);
            Assert.Equal("olleh", resultText);
        }

        [Fact]
        public void ReverseStringWithSpacesTest()
        {
            var inputText = "hello world";
            var resultText = ReverseString(inputText);
            Assert.Equal("dlrow olleh", resultText);
        }

        [Fact]
        public void ReverseSimpleStringTest_Builder()
        {
            var inputText = "hello";
            var resultText = ReverseStringBuilder(inputText);
            Assert.Equal("olleh", resultText);
        }

        [Fact]
        public void ReverseStringWithSpacesTest_Builder()
        {
            var inputText = "hello world";
            var resultText = ReverseStringBuilder(inputText);
            Assert.Equal("dlrow olleh", resultText);
        }

        [Fact]
        public void ReverseSimpleStringTest_Array()
        {
            var inputText = "hello";
            var resultText = ReverseStringArray(inputText);
            Assert.Equal("olleh", resultText);
        }

        [Fact]
        public void ReverseStringWithSpacesTest_Array()
        {
            var inputText = "hello world";
            var resultText = ReverseStringArray(inputText);
            Assert.Equal("dlrow olleh", resultText);
        }

        [Fact]
        public void ReverseSimpleStringTest_LINQ()
        {
            var inputText = "hello";
            var resultText = ReverseStringArrayLinq(inputText);
            Assert.Equal("olleh", resultText);
        }

        [Fact]
        public void ReverseStringWithSpacesTest_LINQ()
        {
            var inputText = "hello world";
            var resultText = ReverseStringArrayLinq(inputText);
            Assert.Equal("dlrow olleh", resultText);
        }

        [Fact]
        public void ReverseSimpleStringTest_ExtensionMethod()
        {
            var inputText = "hello";
            var resultText = ReverseStringExtension(inputText);
            Assert.Equal("olleh", resultText);
        }

        [Fact]
        public void ReverseStringWithSpacesTest_ExtensionMethod()
        {
            var inputText = "hello world";
            var resultText = ReverseStringExtension(inputText);
            Assert.Equal("dlrow olleh", resultText);
        }

        private string ReverseString(string inputText)
        {
            var inputChars = inputText.ToCharArray();
            string retString = string.Empty;

            for (int i = inputChars.Length-1; i >= 0; i--)
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
    }

    static class StringExtensions
    {
        public static string Reverse(this string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray());
        }
    }
}
