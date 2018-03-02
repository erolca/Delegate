using System;

public delegate R Operation<T1, T2, R>(T1 val1, T2 val2)
    where T1 : struct
    where T2 : struct
    where R : struct;

public class MainClass
{
    public static double Add(int val1, float val2)
    {
        return val1 + val2;
    }

    static void Main()
    {
        Operation<int, float, double> op = new Operation<int, float, double>(Add);

        Console.WriteLine("{0} + {1} = {2}", 1, 3.2, op(1, 3.2f));
    }
}
//1 + 3.2 = 4.20000004768372