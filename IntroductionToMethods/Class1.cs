using System;

public class Class1
{
    public static bool getStatus(string myString)
    {
        string first = myString.Substring(0, myString.Length / 2);
        char[] arr = myString.ToCharArray();

        Array.Reverse(arr);

        string temp = new string(arr);
        string second = temp.Substring(0, temp.Length / 2);

        return first.Equals(second);
    }
}
