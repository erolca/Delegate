using System;

class MainClass
{
    delegate int MyDelegate(string s);
    static void Main(string[] args)
    {
        string MyString = "Hello World";


        MyDelegate Multicast = null;

        Multicast += new MyDelegate(DoSomething);
        Multicast += new MyDelegate(DoSomething2);

        Multicast(MyString);
    }

    static int DoSomething(string s)
    {
        Console.WriteLine("DoSomething");

        return 0;
    }
    static int DoSomething2(string s)
    {
        Console.WriteLine("DoSomething2");
        return 0;
    }
}
//DoSomething
//DoSomething2








