using System;

namespace praktikum12;

public class Program
{
    public static void Main(string[] args)
    {
        string result = DeternmineGrade(90);
        Console.WriteLine(result);
    }
    public static string?DeternmineGrade(int score)
    {
        Dictionary<int, string> GradeMap = new Dictionary<int, string>()
        {
            { 90, "A" },
            { 80, "B" },
            { 70, "C" },
            { 60, "D" },
            { 0, "F" }
        };

        foreach (var kv in GradeMap.OrderByDescending(kv => kv.Key)){
            if (score >= kv.Key)
            {
                return kv.Value;
            }
        }

        return null;
    }
}