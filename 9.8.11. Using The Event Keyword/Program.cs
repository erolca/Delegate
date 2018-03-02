using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

public class MyEventArgs : EventArgs
{
    public readonly int Hour;
    public readonly int Minute;
    public readonly int Second;
    public MyEventArgs(int hour, int minute, int second)
    {
        this.Hour = hour;
        this.Minute = minute;
        this.Second = second;
    }
}
public delegate void MyHandler(object clock, MyEventArgs timeInformation);

public class Clock
{
    private int hour;
    private int minute;
    private int second;
    public event MyHandler SecondChanged;
    protected virtual void OnSecondChanged(MyEventArgs e)
    {
        if (SecondChanged != null)
        {
            SecondChanged(this, e);
        }
    }
    public void Run()
    {
        for (; ; )
        {
            System.DateTime dt = System.DateTime.Now;
            if (dt.Second != second)
            {
                MyEventArgs timeInformation = new MyEventArgs(dt.Hour, dt.Minute, dt.Second);
                OnSecondChanged(timeInformation);
            }
            this.second = dt.Second;
            this.minute = dt.Minute;
            this.hour = dt.Hour;
        }
    }
}
public class ConsoleHandler
{
    public void Register(Clock theClock)
    {
        theClock.SecondChanged += new MyHandler(TimeHasChanged);
    }
    public void TimeHasChanged(object theClock, MyEventArgs ti)
    {
        Console.WriteLine("Current Time: {0}:{1}:{2}", ti.Hour.ToString(), ti.Minute.ToString(), ti.Second.ToString());
    }
}
public class Test
{
    public static void Main()
    {
        Clock theClock = new Clock();
        ConsoleHandler dc = new ConsoleHandler();
        dc.Register(theClock);
        theClock.Run();
    }
}