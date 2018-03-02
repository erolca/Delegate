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

class MouseEvent
{
    public void MouseEventHandler()
    {
        Console.WriteLine("Event received by MouseEventHandler object");
    }
}

class KeyEvent
{
    public void KeyEventHandler()
    {
        Console.WriteLine("Event received by KeyEventHandler object");
    }
}

class MainClass
{
    static void handler()
    {
        Console.WriteLine("Event received by EventDemo");
    }

    public static void Main()
    {
        MyEvent evt = new MyEvent();
        MouseEvent xOb = new MouseEvent();
        KeyEvent yOb = new KeyEvent();

        evt.SomeEvent += handler;
        evt.SomeEvent += xOb.MouseEventHandler;
        evt.SomeEvent += yOb.KeyEventHandler;

        evt.OnSomeEvent();
        Console.WriteLine();

        evt.SomeEvent -= xOb.MouseEventHandler;
        evt.OnSomeEvent();
    }
}
//Event received by EventDemo
//Event received by MouseEventHandler object
//Event received by KeyEventHandler object

//Event received by EventDemo
//Event received by KeyEventHandler object