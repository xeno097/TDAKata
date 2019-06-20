using System.Collections.Generic;

namespace SortingItOut
{
    public class SortIt
    {
        public List<int> Balls;
        public string chipher;
        public SortIt()
        {
            this.Balls = new List<int>();
        }

        public SortIt(string to_sort)
        {
            this.chipher = to_sort.ToLower();
            this.Balls = new List<int>();
            this.Clean();
            this.SortString();
        }

        public void Append(int to_add)
        {

            if (this.Balls.Count == 0)
            {
                this.Balls.Add(to_add);
                return;
            }
            this.SortRack(to_add);
        }

        private void SortRack(int to_add)
        {
            List<int> temp_list = new List<int>();
            bool ok = false;

            foreach(int num in this.Balls)
            {
                if ((to_add <= num) && (!ok))
                {
                    temp_list.Add(to_add);
                    ok = true;
                    
                }
                temp_list.Add(num);
            }

            if (!ok) temp_list.Add(to_add);

            this.Balls = temp_list;
        }

        private void SortString()
        {
            if (this.chipher.Length == 1 || this.chipher.Length == 0)
                return;

            string ret = "";

            foreach (int i in this.Balls)
            {
                ret += (char)(i + 'a');
            }

            this.chipher = ret;
        }

        private void Clean()
        {
            foreach(char c in this.chipher)
                if (IsLetter(c)) this.Append(c - 'a');
        }

        private bool IsLetter(char c)
        {
            return ('a' <= c && c <= 'z');
        }
    }
}
