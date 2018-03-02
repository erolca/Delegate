using System;


//	9.2.4.uses the reference parameter of a multicast delegate as a counter

public delegate void DelegateClass(int valCount, ref int refCount);

public class Counter
{
    public static void Main()
    {
        DelegateClass del = (DelegateClass)AddOne + (DelegateClass)AddTwo + (DelegateClass)AddOne;
        int valCount = 0;
        int refCount = 0;
        del(valCount, ref refCount);
        Console.WriteLine("Value count = {0}", valCount); // 0
        Console.WriteLine("Reference count = {0}", refCount); // 4
    }

    public static void AddOne(int valCount, ref int refCount)
    {
        ++valCount;
        ++refCount;
    }

    public static void AddTwo(int valCount, ref int refCount)
    {
        valCount += 2;
        refCount += 2;
    }
}

//Value count = 0
//Reference count = 4