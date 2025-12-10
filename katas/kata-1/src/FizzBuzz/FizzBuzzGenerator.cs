namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";
        private const string FizzBuzz = "FizzBuzz";

        public static List<string> Generate(int count)
        {
            List<string> result = [];

            for (var number = 1; number <= count; number++)
            {
                result.Add("");

                if (IsMultipleOfFifteen(number))
                    result[number - 1] = FizzBuzz;
                else if (IsMultipleOfThree(number))
                    result[number - 1] = Fizz;
                else if (IsMultipleOfFive(number))
                    result[number - 1] = Buzz;
                else
                    result[number - 1] = number.ToString();
            }

            return result;
        }

        private static bool IsMultipleOfFive(int count)
        {
            return count % 5 == 0;
        }

        private static bool IsMultipleOfThree(int count)
        {
            return count % 3 == 0;
        }

        private static bool IsMultipleOfFifteen(int count)
        {
            return count % 15 == 0;
        }
    }
}