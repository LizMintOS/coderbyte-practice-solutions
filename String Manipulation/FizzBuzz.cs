Console.WriteLine(FizzBuzz());
Console.ReadLine();

static string FizzBuzz()
{
    string str = "";
    for (int i = 1; i <= 100; i++)
    {
        str += $"{i} ";
        if (i % 3 == 0) str += "Fizz";
        if (i % 5 == 0) str += "Buzz";

        str += "\n";
    }
    return str;
}