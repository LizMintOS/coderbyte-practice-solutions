char[] removeChars = { 'a', 'B', 'f', 'i' };
string sentence = "Believe in that person";

Console.WriteLine(RemoveCharsFromString(removeChars, sentence));
Console.ReadLine();

static string RemoveCharsFromString(char[] arr, string str)
{
    foreach (char c in arr)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == c) str = str.Remove(i, 1);
        }
    }
    return str;
}