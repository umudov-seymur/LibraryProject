﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomExceptions.Exceptions
{
    public class NegativeValueException : Exception
    {
        public NegativeValueException(string message) : base(message)
        {

        }
    }
}
