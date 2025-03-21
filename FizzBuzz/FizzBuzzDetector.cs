using System.Text.RegularExpressions;
using FizzBuzz;

public class FizzBuzzDetector
{
    public Result GetOverlappings(string input)
    {
        if (string.IsNullOrWhiteSpace(input) || input.Length < 7 || input.Length > 100)
        {
            throw new ArgumentException("An error occured: Input string doesn't meet length constraints.");
        }

        // Apostrophes are included because the task example replaced words containing them,
        // but the task description specifies only alphanumeric words should be processed.
        List<string> words = Regex.Split(input, "([^a-zA-Z0-9']+)").ToList();

        int wordCount = 0;
        int fizzBuzzCount = 0;

        for (int i = 0; i < words.Count; i++)
        {
            if (Regex.IsMatch(words[i], "^[a-zA-Z0-9']+$")) 
            {
                wordCount++;
                bool isFizz = wordCount % 3 == 0;
                bool isBuzz = wordCount % 5 == 0;

                if (isFizz && isBuzz)
                {
                    words[i] = "FizzBuzz";
                    fizzBuzzCount++;
                }
                else if (isFizz)
                {
                    words[i] = "Fizz";
                    fizzBuzzCount++;
                }
                else if (isBuzz)
                {
                    words[i] = "Buzz";
                    fizzBuzzCount++;
                }
            }
        }

        return new Result
        {
            OutputString = string.Concat(words), 
            Count = fizzBuzzCount
        };
    }
}



