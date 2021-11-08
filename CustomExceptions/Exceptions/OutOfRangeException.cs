using System;
using System.Collections.Generic;
using System.Text;

namespace CustomExceptions.Exceptions
{
    public class OutOfRangeException : Exception
    {
        public OutOfRangeException(string message) : base(message)
        {

        }
    }
}
