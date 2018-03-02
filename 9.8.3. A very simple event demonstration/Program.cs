using System;

delegate void MyEventHandler();

class MyEvent
{
    public event MyEventHandler SomeEvent;

    public void OnSomeEvent()
    {
        if (SomeEvent != null)
            SomeEvent();
    }
}

class MainClass
{
    static void handler()
    {
        Console.WriteLine("Event occurred");
    }

    public static void Main()
    {
        MyEvent evt = new MyEvent();

        evt.SomeEvent += handler;

        evt.OnSomeEvent();
    }
}
//Event occurred