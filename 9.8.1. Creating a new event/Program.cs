using System;

public class EventTestClass
{
    private int nValue;

    public delegate void ValueChangedEventHandler();

    public event ValueChangedEventHandler Changed;

    protected virtual void OnChanged()
    {
        if (Changed != null)
            Changed();
        else
            Console.WriteLine("Event fired. No handler!");

    }

    public EventTestClass(int nValue)
    {
        SetValue(nValue);
    }
    public void SetValue(int nV)
    {
        if (nValue != nV)
        {
            nValue = nV;
            OnChanged();
        }
    }
}

public class MainClass
{
    public static void Main()
    {
        EventTestClass etc = new EventTestClass(3);
        etc.SetValue(5);
        etc.SetValue(5);
        etc.SetValue(3);
    }
}