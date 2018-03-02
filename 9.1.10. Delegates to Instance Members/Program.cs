using System;

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
class MainClass
{
    delegate void ProcessHandler(string message);

    public static void Main()
    {
        Machine aMachine = new Machine("computer");
        ProcessHandler ph = new ProcessHandler(aMachine.Process);

        ph("compile");
    }
}
//computer: compile