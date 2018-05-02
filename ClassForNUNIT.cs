using System;

public class ClassForNUnit
{
    public int Sum(int i, int j)
    {
        return i + j;
    }
    public string Concat(string str1, string str2)
    {
        return "Hello " + str1 + " " + str2;
    }
    public int Sum(int[] i)
    {
        int res = 0;
        for (int a = 0; a < i.Length; a++)
        {
            res += i[a];
        }
        return res;
    }
}