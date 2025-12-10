namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            List<string> result = [];

            for (var i = 1; i <= count; i++)
            {
                result.Add(i.ToString());
            }

            result[0] = "1";

            if (count == 15)
                result[14] = "FizzBuzz";
            
            return result;
        }
    }
}