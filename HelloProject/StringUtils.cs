
//Console.WriteLine($"Number of vowels: {vowelCount}");
//Console.WriteLine($"Number of letters: {letterCount}");
//Console.WriteLine($"Number of unique letters: {uniqueLetterCount}");
//Console.WriteLine($"Corrected case: {correctedCase}");
//Console.WriteLine($"Longest word: {longestWord}");
//Console.WriteLine(cleanedCopy);

public static class StringUtils
{

    public static string CleanedCopy(string input2)
    {
        if (string.IsNullOrEmpty(input2))
        {
            return input2;
        }
        return string.Join(" ", input2.Split(
            (char[])null,
            StringSplitOptions.RemoveEmptyEntries));
    }
    public static int CountVowels(string input)
    {
        int count = 0;
        string vowels = "aeiouAEIOU";
        foreach (char c in input)
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }
        return count;
    }

    public static int CountLatters(string input)
    {
        int count = 0;
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                count++;
            }
        }
        return count;
    }
    public static int UniqueLetters(string input)
    {
        HashSet<char> uniqueLetters = new HashSet<char>();
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                char lowerC = char.ToLower(c);
                uniqueLetters.Add(lowerC);
            }
        }
        return uniqueLetters.Count;
    }

    public static string CorrectCase(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }
        string[] words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];

            if (i == 0)
            {
                words[i] = char.ToUpper(word[0]) + word.Substring(1).ToLower();
            }
            else
            {
                words[i] = char.ToLower(words[i][0]) + words[i].Substring(1).ToLower();
            }
        }
        return string.Join(" ", words);
    }

    public static string LongestWord(string input)
    {
        string[] words = input.Split(' ');
        string longestWord = "";
        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }
        return longestWord;
    }

}
