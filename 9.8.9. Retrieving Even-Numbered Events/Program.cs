using System;

public delegate void EvenNumberHandler(int Number);

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
                    OnEvenNumber(CurrentNumber);
                }
            }
        }
    }
}

class EvenNumberHandlerClass
{
    public void EvenNumberFound(int EvenNumber)
    {
        Console.WriteLine(EvenNumber);
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