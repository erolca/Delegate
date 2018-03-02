using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

delegate int IntDelegate(int x);

public class MainClass
{
    static void TransformUpTo(IntDelegate d, int max)
    {
        for (int i = 0; i <= max; i++)
            Console.WriteLine(d(i));
    }

    public static void Main()
    {
        TransformUpTo(delegate (int x) { return x * x; }, 10);
    }

}
//0
//1
//4
//9
//16
//25
//36
//49
//64
//81
//100