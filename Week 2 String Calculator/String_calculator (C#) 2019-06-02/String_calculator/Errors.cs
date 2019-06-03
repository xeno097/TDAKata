using System;
using System.Collections.Generic;
using System.Text;

namespace String_calculator
{
    public class Errors
    {
        public class InvalidValue : Exception
        {
            public InvalidValue(string mex)
            {
                string error = "Number expected but" + mex  +"found";
            }
        } 

        public class EOFException : Exception
        {
            public EOFException()
            {
                string error = "Number expected but EOF found";
            }
        }

        public class NegativeNumber : Exception
        {
            public NegativeNumber()
            {
                string error = "Negatives not allowed";
            }
        }
    }
}
