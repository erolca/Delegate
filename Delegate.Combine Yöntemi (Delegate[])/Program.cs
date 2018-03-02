using System;

delegate string StrMod(string str);

class MainClass
{

    static string replaceSpaces(string a)
    {
        Console.WriteLine("replaceSpaces");
        return a;
    }

    static string removeSpaces(string a)
    {
        Console.WriteLine("removeSpaces");
        return a;
    }

    static string reverse(string a)
    {
        Console.WriteLine("reverseSpaces");
        return a;
    }

    public static void Main()
    {
        StrMod strOp = new StrMod(replaceSpaces);
        string str;

        str = strOp("This is a test.");

        strOp = new StrMod(removeSpaces);
        str = strOp("This is a test.");
        x
        strOp = new StrMod(reverse);
        str = strOp("This is a test.");
    }
}
//replaceSpaces
//removeSpaces
//reverseSpaces