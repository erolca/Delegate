/*using System;

class MainClass
{
    delegate int MyDelegate(string s);

    static void Main(string[] args)
    {
        MyDelegate Del1 = new MyDelegate(DoSomething);
        MyDelegate Del2 = new MyDelegate(DoSomething2);

        string MyString = "Hello World";

        Del1(MyString);
        Del2(MyString);

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
}*/
//DoSomething
//DoSomething2





using System;

/*
 Delegate.Combine Yöntemi (Delegate[])
 Temsilciler dizisi çağırma listelerini birleştirir.
*/

public class Machine
{
    string name;
    public Machine(string name)
    {
        this.name = name;
    }
    public void Process(string message)
    {
        Console.WriteLine("{0}: {1}", name, message);
    }
}

class Test
{
    delegate void ProcessHandler(string message);

    static public void Process(string message)
    {
        Console.WriteLine("Test.Process(\"{0}\")", message);
    }
    public static void Main()
    {
        Machine computer = new Machine("Computer");

        ProcessHandler ph = new ProcessHandler(computer.Process);
        ph = (ProcessHandler)Delegate.Combine(ph, new ProcessHandler(Process));

        ph("compile");
    }
}

//Computer: compile
//Test.Process("compile")