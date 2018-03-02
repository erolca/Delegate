using System;

class MainClass
{
    delegate int FunctionToCall(int InParam);

    static void Main()
    {
        FunctionToCall del = delegate (int x) {
            return x + 20;
        };
        Console.WriteLine("{0}", del(5));
        Console.WriteLine("{0}", del(6));




    }
}
//25
//26