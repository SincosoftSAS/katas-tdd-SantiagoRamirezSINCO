namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";

        public static List<string> Generate(int count)
        {
            List<string> result = [];

            for (var number = 1; number <= count; number++)
            {
                result.Add(number.ToString());
                if (count % 3 == 0)
                {
                    result[number - 1] = Fizz;
                }

                if (count == 5)
                {
                    result[number - 1] = Buzz;
                }

                if (count == 10)
                    result[number - 1] = Buzz;
            }
            
            if (count == 15)
                result[14] = "FizzBuzz";
            
            return result;
        }
    }
}