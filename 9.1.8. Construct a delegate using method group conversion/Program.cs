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

        StrMod strOp = replaceSpaces; // use method group conversion 
        string str;

        // Call methods through the delegate. 
        str = strOp("This is a test.");


        strOp = removeSpaces; // use method group conversion 
        str = strOp("This is a test.");


        strOp = reverse; // use method group converison 
        str = strOp("This is a test.");
    }

}
//replaceSpaces
//removeSpaces
//reverseSpaces