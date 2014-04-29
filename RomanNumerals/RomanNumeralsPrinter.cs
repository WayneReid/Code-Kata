namespace RomanNumerals
{
    public class RomanNumeralsPrinter
    {
        public string Print(int number)
        {
            string val = string.Empty;

            //while (number >= 1000)
            //{
            //    val += "M";
            //    number-=1000;
            //}

            //if (number >= 900)
            //{
            //    val += "CM";
            //    number -= 900;
            //}

            //if (number >= 500)
            //{
            //    val += "D";
            //    number -= 500;
            //}
            //if (number >= 400)
            //{
            //    val += "CD";
            //    number -= 400;
            //}
            //while (number >= 100)
            //{
            //    val += "C";
            //    number -= 100;
            //}
            //if (number >= 90)
            //{
            //    val += "XC";
            //    number -= 90;
            //}

            //if (number >= 50)
            //{
            //    val += "L";
            //    number -= 50;
            //}

            //if (number >= 40)
            //{
            //    val += "XL";
            //    number -= 40;
            //}

            //while (number >= 10)
            //{
            //    val += "X";
            //    number -= 10;
            //}

            //if (number == 9)
            //{
            //    val += "IX";
            //    number -= 9;
            //}
            //if (number >= 5)
            //{
            //    val += "V";
            //    number -= 5;
            //}
            //if (number == 4)
            //{
            //    val += "IV";
            //    number -= 4;
            //}
            //while (number > 0 && number < 4)
            //{
            //    val += "I";
            //    number--;
            //}


            int[] decimalValues = new [] {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
            string[] romanNumerals = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};

            foreach (int decimalValue in decimalValues)
            {
                
            }


            return val;
        }
    }
}
