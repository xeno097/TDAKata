

using System;
using System.Collections.Generic;

namespace RangeCalculatorKata
{
    public class RangeCalculator
    {
        int low;
        int high;

        public RangeCalculator(string range)
        {
            string[] bounds = range.Substring(1, range.Length - 2).Split(",");
            this.low = GetLowerBound(range[0], bounds[0]);
            this.high = GetUpperBound(range[range.Length - 1], bounds[1]);
        }

        private int GetLowerBound(char parentesis, string num)
        {
            int ret = Convert.ToInt32(num);
            return parentesis == '[' ? ret : ret + 1;
        }

        private int GetUpperBound(char parentesis, string num)
        {
            int ret = Convert.ToInt32(num);
            return parentesis == ']' ? ret : ret - 1; 

        }

        public bool Range(string tocheck)
        {
            string[] numsToCheck = tocheck.Substring(1, tocheck.Length - 2).Split(",");
            
            foreach(string n in numsToCheck)
            {
                int v = Convert.ToInt32(n);
                if(!(v>=low && v<=high))
                {
                    return false;
                }
            }

            return true;
        }

        public bool Contains(string toCheck)
        {
            string[] bounds = toCheck.Substring(1, toCheck.Length - 2).Split(",");
            int toCheckLow = GetLowerBound(toCheck[0], bounds[0]);
            int toCheckHigh = GetUpperBound(toCheck[toCheck.Length - 1], bounds[1]);

            return (toCheckLow >= this.low && toCheckHigh <= this.high);
        }

        public string GetAllPoints()
        {
            string ret = "{";
           
            for(int i = this.low; i <= this.high;i++)
                ret += Convert.ToString(i) + ',';

            ret = ret.Substring(0,ret.Length-1) + '}';

            return ret;
        }

        public string EndPoints()
        {
            string ret = "{" + Convert.ToString(this.low) + "," + Convert.ToString(this.high) + "}";
            return ret;
        }

        public bool AreEquals(string toCheck)
        {
            string[] bounds = toCheck.Substring(1, toCheck.Length - 2).Split(",");
            int toCheckLow = GetLowerBound(toCheck[0], bounds[0]);
            int toCheckHigh = GetUpperBound(toCheck[toCheck.Length - 1], bounds[1]);

            return (toCheckLow == this.low && toCheckHigh == this.high);
        }

        public bool OverLaps(string toCheck)
        {
            bool ret = false;
            string[] bounds = toCheck.Substring(1, toCheck.Length - 2).Split(",");
            int toCheckLow = GetLowerBound(toCheck[0], bounds[0]);
            int toCheckHigh = GetUpperBound(toCheck[toCheck.Length - 1], bounds[1]);

            if (this.low <= toCheckLow && this.high >= toCheckHigh) return true;
            else if (this.low >= toCheckLow && this.high <= toCheckHigh) return true;

            return ret;
        }
    }
}
