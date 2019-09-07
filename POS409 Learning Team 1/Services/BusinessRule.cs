using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace POS409_Learning_Team_1.Services
{
    public class BusinessRule
    {
        static public bool IsZipCode(string zipCode)
        {
            bool IsZipCode = false;
            string pattern = @"^\d{5}-\d{4}|\d{5}|[A-Z]\d[A-Z] \d[A-Z]\d$";
            Regex regex = new Regex(pattern);
            return IsZipCode = regex.IsMatch(zipCode);
        }
    }
}
