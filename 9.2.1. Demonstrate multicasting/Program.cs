using System;

delegate string StrMod(ref string str);

class MultiCastDemo
{
    static string replaceSpaces(ref string a)
    {
        Console.WriteLine("replaceSpaces");
        return a;
    }

    static string removeSpaces(ref string a)
    {
        Console.WriteLine("removeSpaces");
        return a;
    }

    static string reverse(ref string a)
    {
        Console.WriteLine("reverseSpaces");
        return a;
    }

    public static void Main()
    {
        StrMod strOp;
        StrMod replaceSp = new StrMod(replaceSpaces);
        StrMod removeSp = new StrMod(removeSpaces);
        StrMod reverseStr = new StrMod(reverse);
        string str = "This is a test";

        // Set up multicast. 
        strOp = replaceSp;
        strOp += reverseStr;

        // Call multicast. 
        strOp(ref str);

        // Remove replace and add remove. 
        strOp -= replaceSp;
        strOp += removeSp;

        str = "This is a test."; // reset string 

        // Call multicast. 
        strOp(ref str);
    }
}
//replaceSpaces
//reverseSpaces
//reverseSpaces
//removeSpaces