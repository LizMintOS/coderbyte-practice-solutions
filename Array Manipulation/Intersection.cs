string[] strs = { "1, 2, 3, 4, 5, 6, 7", "6, 7, 8, 9, 10" };

Console.WriteLine(ArrayIntersection(strs));
Console.ReadLine();

static string ArrayIntersection(string[] strs)
{

    string[] s1 = strs[0].Replace(" ", "").Split(",");
    string[] s2 = strs[1].Replace(" ", "").Split(",");
    string finalStr = "No intersection";

    var intersection = s2.Intersect(s1).ToArray();

    if (intersection.Length > 0)
    {
        finalStr = string.Join(",", intersection);
    }
    
    return finalStr;
}