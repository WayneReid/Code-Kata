namespace RomanNumerals
{
    public class RomanNumeralsPrinter
    {
        public string Print(int number)
        {
            string val = string.Empty;
            int[] decimalValues = new [] {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
            string[] romanNumerals = new[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};

            for (int decimalIndex = 0; decimalIndex < decimalValues.Length; decimalIndex++)
            {
                int decimalValue = decimalValues[decimalIndex];
                while (number >= decimalValue)
                {
                    val += romanNumerals[decimalIndex];
                    number -= decimalValue;
                }
            }

            return val;
        }
    }
}
