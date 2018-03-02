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

class KeyEvent
{

    public static void KeyEventHandler()
    {
        Console.WriteLine("Event received by class.");
    }
}

class MainClass
{
    public static void Main()
    {
        MyEvent evt = new MyEvent();

        evt.SomeEvent += KeyEvent.KeyEventHandler;

        evt.OnSomeEvent();
    }
}
//Event received by class.