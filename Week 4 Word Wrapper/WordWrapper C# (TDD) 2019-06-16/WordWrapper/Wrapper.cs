using System;
using System.Collections.Generic;
using System.Text;

namespace WordWrapper
{
    public class Wrapper
    {

        string[] words;
        int maxLen;

        public Wrapper(string _string, int _maxLen)
        {
            this.words = _string.Split(" ");
            this.maxLen = _maxLen;
            this.Wrap();
        }
        private void CheckWrap()
        {
            foreach(string s in this.words)
            {
                if (s.Length > this.maxLen) throw new NotWrappableWordsException();
             
            }
        }

        public string Wrap()
        {

            this.CheckWrap();

            string ret = "";

            bool flag = false;
            string line = "";
            foreach(string s in this.words)
            {
                if((line + s + ' ').Length > this.maxLen)
                {
                    for (int i = 0; i < this.maxLen - line.Length; i++) line += " ";
                    ret += line +'\n';
                    line = "";
                    flag = true;
                }
                line += s;
                if (line.Length < this.maxLen)
                {
                    line += ' ';
                }

                flag = false;
            }

            int index = words.Length - 1;

            if (flag) ret += this.words[index];
            else if((line + words[index]).Length > maxLen)
            {
                for (int i = 0; i < maxLen - line.Length; i++) line += " ";
                ret += line +'\n';
            }
            else ret+= words[index];


            return ret;
        }
    }
}
