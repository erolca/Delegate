using System;

delegate string StrMod(string str);

class StringOps
{
    public static string replaceSpaces(string a)
    {
        Console.WriteLine("replaceSpaces");
        return a;
    }

    public static string removeSpaces(string a)
    {
        Console.WriteLine("removeSpaces");
        return a;
    }

    public static string reverse(string a)
    {
        Console.WriteLine("reverseSpaces");
        return a;
    }
}

class MainClass
{
    public static void Main()
    {

        // Initialize a delegate. 
        StrMod strOp = new StrMod(StringOps.replaceSpaces);
        string str;

        // Call methods through delegates. 
        str = strOp("This is a test.");

        strOp = new StrMod(StringOps.removeSpaces);
        str = strOp("This is a test.");

        strOp = new StrMod(StringOps.reverse);
        str = strOp("This is a test.");

    }
}
//replaceSpaces
//removeSpaces
//reverseSpaces