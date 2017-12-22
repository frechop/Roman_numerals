using System;
using System.Text;

namespace Roman_Numerals
{
    public static class Roman
    {
        // Due to limitation 0 < x < 3999 Recursive approach using String is acceptable
        public static string ConvertToRoman(int number)
        {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("Inserted number is out of range");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M " + ConvertToRoman(number - 1000);
            if (number >= 900) return "CM " + ConvertToRoman(number - 900);
            if (number >= 500) return "D " + ConvertToRoman(number - 500);
            if (number >= 400) return "CD " + ConvertToRoman(number - 400);
            if (number >= 100) return "C " + ConvertToRoman(number - 100);
            if (number >= 90) return "XC " + ConvertToRoman(number - 90);
            if (number >= 50) return "L " + ConvertToRoman(number - 50);
            if (number >= 40) return "XL " + ConvertToRoman(number - 40);
            if (number >= 10) return "X " + ConvertToRoman(number - 10);
            if (number >= 9) return "IX " + ConvertToRoman(number - 9);
            if (number >= 5) return "V " + ConvertToRoman(number - 5);
            if (number >= 4) return "IV " + ConvertToRoman(number - 4);
            if (number >= 1) return "I " + ConvertToRoman(number - 1);
            throw new ArgumentException("Incorrect input");
        }

        // Assumed that string Length is limited to Int32 MaxValue and numbers are within the range
        public static Tuple<string, int> ReplaceIntegersInText(string text)
        {
            StringBuilder result = new StringBuilder();
            int replacementCounter = new int();

            for (int i = 0; i < text.Length;)
            {
                if (char.IsDigit(text[i]))
                {
                    string foundNumberAsText = string.Empty;

                    do
                    {
                        foundNumberAsText += text[i];
                    }
                    while (char.IsDigit(text[++i]));

                    int.TryParse(foundNumberAsText, out var foundNumber);
                    string RomanLiteral = ConvertToRoman(foundNumber);
                    RomanLiteral = RomanLiteral.Remove(RomanLiteral.Length - 1);
                    result.Append(RomanLiteral);
                    replacementCounter++;
                    continue;
                }
                else
                {
                    result.Append(text[i]);
                    i++;
                }
            }
            return new Tuple<string, int>(result.ToString(), replacementCounter);
        }
    }
}
