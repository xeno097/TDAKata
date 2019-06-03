

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static String_calculator.Errors;

namespace String_calculator
{
    public class StringAdd
    {
        private bool IsDigit(string v)
        {
            if (v.Length == 0) return false;

            bool ret = true;

            foreach(char c in v) if (c - '0' < 0 && c - '0' > 9) ret = false;

            return ret;
        }

        private List<int> splitter(string v)
        {
            if(v[v.Length-1]==','|| v[v.Length - 1] == '\n')
            {
                throw new EOFException();
            }

            List<string> temp = new List<string>(Regex.Split(v,"\n|,"));
            List<int> ret = new List<int>();

            foreach (var i in temp)
            {
                if (IsDigit(i)) ret.Add(Convert.ToInt32(i));
                else throw new InvalidValue(i);

            }

            return ret;
        }

        public string Add(string v)
        {
            if (v.Length == 0) return "0";

            int ret = 0;
            List<int> nums = splitter(v);

            foreach (int i in nums)
            {
                if (i < 0) throw new NegativeNumber();
                ret += i;
            }

            return Convert.ToString(ret);
        }
    }
}
