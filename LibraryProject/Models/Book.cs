using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using CustomExceptions.Exceptions;
using CustomValidations.Validations;

namespace LibraryProject.Models
{
    class Book
    {
        private static int _incrementCount;
        public int Id { get; }
        public string Name
        {
            get { return Name; }
            set { _ = value.Trim(); }
        }

        private string _author { get; set; }
        public string Author
        {
            get { return _author; }
            set
            {
                if (!BookValidation.IsValidAuthor(value.Trim()))
                {
                    throw new NotValidAuthorException("This author name is invalid.");
                }
                _ = value.Trim();
            }
        }

        private double _price;
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (_price > 0)
                {
                    _price = value;
                }
                throw new NegativeValueException("The price must be at least 1");
            }
        }

        static Book()
        {
            _incrementCount = 1;
        }

        public Book()
        {
            Id = _incrementCount++;
        }

        public Book(string name) : this()
        {
            Name = name;
        }
    }
}
