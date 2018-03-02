using System;
using System.Threading;


public delegate void DelegateClass();

public class Starter
{
    public static void Main()
    {
        DelegateClass del = delegate {
            Console.WriteLine("Running anonymous method");
        };
        del();
    }
}