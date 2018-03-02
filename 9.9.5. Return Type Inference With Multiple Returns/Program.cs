using System;
using System.ComponentModel;

delegate T MyFunc<T>();
class MainClass
{
    static void WriteResult<T>(MyFunc<T> function)
    {
        Console.WriteLine(function());
    }

    static void Main()
    {
        WriteResult(delegate
        {
            if (1 > 2)
            {
                return 10;
            }
            else
            {
                return new object();
            }
        });
    }
}