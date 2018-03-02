using System;

public delegate double ComputeDelegate(double x, double y);

public class MyClass
{
    public MyClass()
    {
    }

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

    private double factor;
}

public class MainClass
{
    static void Main()
    {
        MyClass proc1 = new MyClass();
        MyClass proc2 = new MyClass();

        ComputeDelegate[] delegates = new ComputeDelegate[] {
            new ComputeDelegate( proc1.Add ),
            new ComputeDelegate( proc2.Add ),
            new ComputeDelegate( MyClass.Subtract )
        };

        ComputeDelegate chained = (ComputeDelegate)Delegate.Combine(delegates);

        double combined = chained(4, 5);

        Console.WriteLine("Output: {0}", combined);
    }
}
//InstanceResults: 9
//InstanceResults: 9
//StaticResult: -1
//Output: -1