Console.WriteLine(ReverseString("Hello!"));
Console.ReadLine();
static string ReverseString(string input)
{
    char[] chars = input.ToCharArray();
    Array.Reverse(chars);
    return new string(chars);
}

OR

string originalStr = "Hello!";
string reverseStr = new(originalStr.Reverse().ToArray());
Console.WriteLine(reverseStr);
Console.ReadLine();