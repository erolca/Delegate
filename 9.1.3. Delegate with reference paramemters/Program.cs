using System;

delegate void FunctionToCall(ref int X);

class MainClass
{
    public static void Add2(ref int x)
    {
        x += 2;
    }

    public static void Add3(ref int x)
    {
        x += 3;
    }

    static void Main(string[] args)
    {
        FunctionToCall functionDelegate = Add2;
        functionDelegate += Add3;
        functionDelegate += Add2;

        int x = 5;
        functionDelegate(ref x);

        Console.WriteLine("Value: {0}", x);
    }
}
//Value: 12