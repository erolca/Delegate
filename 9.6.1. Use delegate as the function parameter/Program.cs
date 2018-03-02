using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

delegate void FooBar();

public class MainClass
{
    static void Invoke3Times(FooBar d)
    {
        d(); d(); d();
    }

    public static void Main()
    {
        int i = 0;
        Invoke3Times(delegate { i++; });
        Console.WriteLine(i);

    }

}
//3