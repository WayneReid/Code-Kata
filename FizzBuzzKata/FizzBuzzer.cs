namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string Request(int number)
        {
            string returnVal = string.Empty;

            if (number%3 == 0)
                returnVal += "fizz";

            if (number%5 == 0)
                returnVal += "buzz";

            return returnVal;
        }
    }
}