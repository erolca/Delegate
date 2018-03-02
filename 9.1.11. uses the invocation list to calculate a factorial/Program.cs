using System;

public delegate int IncrementDelegate(ref short refCount);

public class Factorial
{
    public static void Main()
    {

        IncrementDelegate[] values = { Incrementer, Incrementer, Incrementer, Incrementer, Incrementer };
        IncrementDelegate del = (IncrementDelegate)
       IncrementDelegate.Combine(values);
        long result = 1;
        short count = 1;
        foreach (IncrementDelegate number in del.GetInvocationList())
        {
            result = result * number(ref count);
        }
        Console.WriteLine("{0} factorial is {1}", del.GetInvocationList().Length, result);
    }

    public static int Incrementer(ref short refCount)
    {
        return refCount++;
    }

}