using System;

public delegate void EventHandler(int i);

class MainClass
{
    static void Main(string[] args)
    {
        MyEventPublisher EventPublisher = new MyEventPublisher();


        EventHandler MyAnonymousDelegate = delegate (int x)
        {
            Console.WriteLine("Anonymous Event FIRED!");
        };

        EventPublisher.MyEvent += MyAnonymousDelegate;

        EventPublisher.DoSomething();
    }

}

public class MyEventPublisher
{
    public event EventHandler MyEvent;
    public int DoSomething()
    {
        MyEvent(5);
        return 0;
    }
}
//Anonymous Event FIRED!