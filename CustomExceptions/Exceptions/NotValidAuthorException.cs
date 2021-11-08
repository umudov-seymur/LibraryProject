using System;
using System.Collections.Generic;
using System.Text;

namespace CustomExceptions.Exceptions
{
    public class NotValidAuthorException : Exception
    {
        public NotValidAuthorException(string message) : base(message)
        {

        }
    }
}
