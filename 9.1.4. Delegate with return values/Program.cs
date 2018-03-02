using System;

delegate int FunctionToCall();

class MainClass
{
    static int IntValue = 5;

    public static int Add2()
    {
        IntValue += 2;
        return IntValue;
    }

    public static int Add3()
    {
        IntValue += 3;
        return IntValue;
    }

    static void Main()
    {
        FunctionToCall functionDelegate = Add2;
        functionDelegate += Add3;
        functionDelegate += Add2;

        Console.WriteLine("Value: {0}", functionDelegate());
    }
}
//Value: 12