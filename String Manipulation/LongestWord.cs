using System.Text.RegularExpressions;

static string LongestWord(string sen)
{
    string longestWord = "";

    string[] splitSen = sen.Split(' ');

    foreach (string str in splitSen)
    {
        string newWord = Regex.Replace(str, @"[^a-zA-Z0-9]", "");
        if (longestWord.Length < newWord.Length)
        {
            longestWord = newWord;
        }
    }

    return longestWord;
}