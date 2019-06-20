using NUnit.Framework;
using SortingItOut;
using System;
using System.Collections.Generic;
using System.Text;

namespace SortingItOutTests
{
    [TestFixture]
    class SortItTest
    {
        [Test]
        public void WithEmptyList_returns_Empty()
        {
            SortIt sortIt = new SortIt();
            List<int> test_list = new List<int>();
            Assert.AreEqual(test_list,sortIt.Balls);
        }

        [Test]
        public void WithOneNumber_returns_OneNumberList()
        {
            SortIt sortIt = new SortIt();
            sortIt.Append(10);
            List<int> test_list = new List<int>();
            test_list.Add(10);
            Assert.AreEqual(test_list, sortIt.Balls);
        }

        [Test]
        public void WithTwoNumbers_returns_OrderedTwoNUmberList()
        {
            SortIt sortIt = new SortIt();
            sortIt.Append(20);
            sortIt.Append(10);
            List<int> test_list = new List<int>();
            test_list.Add(20);
            test_list.Add(10);
            test_list.Sort();
            Assert.AreEqual(test_list, sortIt.Balls);
        }

        [Test]
        public void WithListOfNumbers_returns_OrderedNumberList()
        {
            SortIt sortIt = new SortIt();
            sortIt.Append(20);
            sortIt.Append(10);
            sortIt.Append(30);
            List<int> test_list = new List<int>();
            test_list.Add(20);
            test_list.Add(10);
            test_list.Add(30);
            test_list.Sort();
            Assert.AreEqual(test_list, sortIt.Balls);
        }

        [Test]
        public void WithListOfRandomNumbers_returns_OrderedNumberList()
        {
            Random random = new Random();
            SortIt sortIt = new SortIt();

            int n = random.Next(0, 60);

            for(int i = 0; i < n; i++)
            {
                int num = random.Next(0, 60);
                sortIt.Append(num);
            }

            List<int> test_list = sortIt.Balls;

            test_list.Sort();
            Assert.AreEqual(test_list, sortIt.Balls);
        }

        [Test]
        public void WithEmptyString_returns_EmptyString()
        {
            SortIt sortIt = new SortIt("");

            string test_list = "";

            Assert.AreEqual(test_list, sortIt.chipher);
        }

        [Test]
        public void WithOneLetter_returns_Letter()
        {
            SortIt sortIt = new SortIt("a");
            
            string test_list = "a";

            Assert.AreEqual(test_list, sortIt.chipher);
        }

        [Test]
        public void WithTwoLetters_returns_SortedString()
        {
            SortIt sortIt = new SortIt("ba");

            string test_string = "ba";
            List<char> test_list = new List<char>(test_string);
            test_list.Sort();
            string temp = ""; 

            foreach(char c in test_list)
            {
                temp += c;
            }
            test_string = temp;

            Assert.AreEqual(test_string, sortIt.chipher);
        }

        [Test]
        public void WithAString_returns_SortedString()
        {
            SortIt sortIt = new SortIt("When not studying nuclear physics, Bambi likes to play beach volleyball.");

            string test_string = "aaaaabbbbcccdeeeeeghhhiiiiklllllllmnnnnooopprsssstttuuvwyyyy";

            Assert.AreEqual(test_string, sortIt.chipher);
        }
    }
}
