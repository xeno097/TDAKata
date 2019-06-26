using System;
using System.Collections.Generic;
using System.Text;

namespace NumberInWords
{

    public class VConverter
    {

        Dictionary<int, string> numstrings;

        public VConverter()
        {
            this.numstrings = new Dictionary<int, string>();

            this.numstrings.Add(1, "one");
            this.numstrings.Add(2, "two");
            this.numstrings.Add(3, "three");
            this.numstrings.Add(4, "four");
            this.numstrings.Add(5, "five");
            this.numstrings.Add(6, "six");
            this.numstrings.Add(7, "seven");
            this.numstrings.Add(8, "eight");
            this.numstrings.Add(9, "nine");
            this.numstrings.Add(10, "ten");
            this.numstrings.Add(11, "eleven");
            this.numstrings.Add(12, "twelve");
            this.numstrings.Add(13, "thirteen");
            this.numstrings.Add(14, "fourteen");
            this.numstrings.Add(15, "fifteen");
            this.numstrings.Add(16, "sixteen");
            this.numstrings.Add(17, "seventeen");
            this.numstrings.Add(18, "eighteen");
            this.numstrings.Add(19, "nineteen");
            this.numstrings.Add(20, "twenty");
            this.numstrings.Add(30, "thirty");
            this.numstrings.Add(40, "forty");
            this.numstrings.Add(50, "fifty");
            this.numstrings.Add(60, "sixty");
            this.numstrings.Add(70, "seventy");
            this.numstrings.Add(80, "eighty");
            this.numstrings.Add(90, "ninety");
            this.numstrings.Add(100, "hundred");
            this.numstrings.Add(1000, "thousand");
        }


        int Pow10(int x)
        {
            int ret = 1;
            for(int i = 0; i < x; i++)
            {
                ret *= 10;
            }
            return ret;
        }

        public string NumToString(int num)
        {
            if (num == 1)
            {
                return "one dollar";
            }
            string ret = "";

            string to_string = Convert.ToString(num);
            int len = to_string.Length - 1;

            if (num < 21)
            {
                ret = numstrings[num] + ' ';
            }
            else
            {
                foreach (char c in to_string)
                {

                    if (len < 2)
                    {
                        int digit = c - '0';
                        int key = digit * this.Pow10(len);
                        ret += numstrings[key] + ' ';
                    }
                    else
                    {
                        int digit = c - '0';
                        int key = this.Pow10(len);
                        ret += numstrings[digit] +' '+ numstrings[key] + ' ';
                    }
                    len--;
                }
            }


            ret += "dollars";

            return ret;
            
        } 
    }
}
