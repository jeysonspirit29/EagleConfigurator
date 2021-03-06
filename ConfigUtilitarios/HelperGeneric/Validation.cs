﻿using ConfigUtilitarios.KeyValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace ConfigUtilitarios
{
    public class Validation
    {
        public static bool EsEmail(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool PositiveAmount(string amount, decimal upperLimit = KeyAmounts.MaxAmount)
        {
            return decimal.TryParse(amount, out decimal _amount) &&
                    _amount > 0 &&
                    _amount <= upperLimit;

        }
        public static bool PositiveAmount(decimal amount, decimal upperLimit = KeyAmounts.MaxAmount)
        {
            return amount > 0 &&
                    amount <= upperLimit;
        }
        public static bool IsValidImage(string filename)
        {
            try
            {
                using (Image newImage = Image.FromFile(filename))
                { }
            }
            catch (OutOfMemoryException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static bool IsNullOrEmptyOrSpace(string something)
        {
            return string.IsNullOrEmpty(something) || something.Trim() == string.Empty;
        }
    }
}
