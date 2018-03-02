using System;

public delegate void MyDeleage();

public class MainClass
{
    public static MyDeleage[] CreateDelegates()
    {
        MyDeleage[] delegates = new MyDeleage[3];

        for (int i = 0; i < 3; ++i)
        {
            delegates[i] = delegate {
                Console.WriteLine("Hi");
            };
        }
        return delegates;
    }

    static void Main()
    {
        MyDeleage[] delegates = CreateDelegates();
        for (int i = 0; i < 3; ++i)
        {
            delegates[i]();
        }
    }
}
//Hi
//Hi
//Hi