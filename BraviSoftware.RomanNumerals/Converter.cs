using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BraviSoftware.RomanNumerals
{
    public class Converter
    {
        public static string Convert(int number)
        {
            Dictionary<int, string> characters = new Dictionary<int, string> {
                { 1000, "M"}, 
                { 900, "CM"}, 
                { 500, "D"}, 
                { 400, "CD"}, 
                { 100, "C"}, 
                { 90,"XC"}, 
                { 50, "L" }, 
                { 40, "XL" }, 
                { 10, "X" }, 
                { 9, "IX" },
                { 5, "V" }, 
                { 4, "IV" }, 
                { 1, "I" } 
            };
            string roman = string.Empty;
            foreach (var pair in characters)
            {
                while (number >= pair.Key)
                {
                    roman += pair.Value;
                    number -= pair.Key;
                }
            }

            return roman;
        }
    }
}
