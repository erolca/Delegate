using System;

public delegate double Compute(double x, double y);

public class Processor
{
    public double Add(double x, double y)
    {
        double result = x + y;
        Console.WriteLine("InstanceResults: {0}", result);
        return result;
    }

    public static double Subtract(double x, double y)
    {
        double result = x - y;
        Console.WriteLine("StaticResult: {0}", result);
        return result;
    }
}

public class MainClass
{
    static void Main()
    {
        Processor proc1 = new Processor();
        Processor proc2 = new Processor();

        Compute[] delegates = new Compute[] {
            new Compute( proc1.Add ),
            new Compute( proc2.Add ),
            new Compute( Processor.Subtract )
        };

        Compute chained = (Compute)Delegate.Combine(delegates);
        Delegate[] chain = chained.GetInvocationList();


        for (int i = 0; i < chain.Length; ++i)
        {
            Compute current = (Compute)chain[i];
            Console.WriteLine(current(4, 5));
        }


    }
}
//InstanceResults: 9
//9
//InstanceResults: 9
//9
//StaticResult: -1
//-1