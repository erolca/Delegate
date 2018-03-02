using System;


//9.8.5.	Individual objects receive notifications when instance event handlers are used


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
    int id;

    public KeyEvent(int x)
    {
        id = x;
    }

    public void KeyEventHandler()
    {
        Console.WriteLine("Event received by object " + id);
    }
}

class MainClass
{
    public static void Main()
    {
        MyEvent evt = new MyEvent();
        KeyEvent o1 = new KeyEvent(1);
        KeyEvent o2 = new KeyEvent(2);
        KeyEvent o3 = new KeyEvent(3);

        evt.SomeEvent += o1.KeyEventHandler;
        evt.SomeEvent += o2.KeyEventHandler;
        evt.SomeEvent += o3.KeyEventHandler;

        evt.OnSomeEvent();
    }
}
//Event received by object 1
//Event received by object 2
//Event received by object 3