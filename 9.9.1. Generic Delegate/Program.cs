using System;
using System.Collections.Generic;

delegate void FunctionToCall<T>(T value);

class MainClass
{
    static public void PrintString(string s)
    {
        Console.WriteLine(s);
    }
    static public void PrintUpperString(string s)
    {
        Console.WriteLine("{0}", s.ToUpper());
    }

    static void Main()
    {
        FunctionToCall<string> functionDelegate = PrintString;
        functionDelegate += PrintUpperString;
        functionDelegate("Hi There.");
    }
}
//Hi There.
//HI THERE.