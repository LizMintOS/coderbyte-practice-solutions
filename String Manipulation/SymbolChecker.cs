string sentence = "( and ) then  and (";
Console.WriteLine(MatchingSymbols(sentence));
Console.ReadLine();

static bool MatchingSymbols(string symbols)
{
    int count = 0;
    foreach (char c in symbols)
    {
        if (c == '(') count++;
        if (c == ')') count--;
    }

    if (count == 0) return true;
    return false;
}