namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
<<<<<<< HEAD
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";
        private const string FizzBuzz = "FizzBuzz";

        public static List<string> Generate(int count)
        {
            List<string> result = [];

            for (var number = 1; number <= count; number++)
            {
                result.Add("");
                
                if (IsMultipleOfFifteen(count))
                    result[number - 1] = FizzBuzz;
                else if (IsMultipleOfThree(count))
                    result[number - 1] = Fizz;
                else if (IsMultipleOfFive(count))
                    result[number - 1] = Buzz;
                else
                    result[number - 1] = number.ToString();
            }
            
            return result;
=======
        public static List<string> Generate(int count)
        {
            // TODO: Implement FizzBuzz logic using TDD
            // Start with the simplest case that makes the first test pass
            throw new NotImplementedException("Implement using TDD: Red → Green → Refactor");
>>>>>>> e28ed8faa7700dbd0f99df232351e36c37a03f67
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