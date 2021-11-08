using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CustomValidations.Validations
{
    public static class BookValidation
    {
        /// <summary>
        /// Author checks name in correct format
        /// </summary>
        /// <param name="author"></param>
        /// <returns>bool</returns>
        public static bool IsValidAuthor(string author)
        {
            return Regex.IsMatch(author, @"^[a-zA-Z\, \-]+$");
        }
    }
}
