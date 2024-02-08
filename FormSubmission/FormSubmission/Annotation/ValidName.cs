using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace FormSubmission.Annotation
{
    public class ValidName : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string chr = "^[a-zA-Z\\-\\.\\s]+$";
            if (value == null)
            {
                return false;
            }
            var name = (string)value;
            return Regex.IsMatch(name, chr);
        }
    }
}