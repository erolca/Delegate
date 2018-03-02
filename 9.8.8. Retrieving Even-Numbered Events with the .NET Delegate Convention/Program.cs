using System;

public delegate void EvenNumberHandler(object Originator, OnEvenNumberEventArgs EvenNumberEventArgs);

class Counter
{
    public event EvenNumberHandler OnEvenNumber;

    public Counter()
    {
        OnEvenNumber = null;
    }

    public void CountTo100()
    {
        int CurrentNumber;

        for (CurrentNumber = 0; CurrentNumber <= 100; CurrentNumber++)
        {
            if (CurrentNumber % 2 == 0)
            {
                if (OnEvenNumber != null)
                {
                    OnEvenNumberEventArgs EventArguments;

                    EventArguments = new OnEvenNumberEventArgs(CurrentNumber);
                    OnEvenNumber(this, EventArguments);
                }
            }
        }
    }
}

public class OnEvenNumberEventArgs : EventArgs
{
    private int EvenNumber;

    public OnEvenNumberEventArgs(int EvenNumber)
    {
        this.EvenNumber = EvenNumber;
    }

    public int Number
    {
        get
        {
            return EvenNumber;
        }
    }
}

class EvenNumberHandlerClass
{
    public void EvenNumberFound(object Originator, OnEvenNumberEventArgs EvenNumberEventArgs)
    {
        Console.WriteLine(EvenNumberEventArgs.Number);
    }
}

class MainClass
{
    public static void Main()
    {
        Counter MyCounter = new Counter();
        EvenNumberHandlerClass MyEvenNumberHandlerClass = new EvenNumberHandlerClass();
        MyCounter.OnEvenNumber += new EvenNumberHandler(MyEvenNumberHandlerClass.EvenNumberFound);
        MyCounter.CountTo100();
    }
}