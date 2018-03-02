using System;

class Program
{
    delegate void MessagePrintDelegate(string msg);

    static void Main(string[] args)
    {

        MessagePrintDelegate mpd = new MessagePrintDelegate(PrintMessage);
        LongRunningMethod(mpd);

    }

    static void LongRunningMethod(MessagePrintDelegate mpd)
    {
        for (int i = 0; i < 99; i++)
        {
            if (i % 25 == 0)
            {
                mpd(string.Format("Progress Made. {0}% complete.", i));
            }
        }
    }

    static void PrintMessage(string msg)
    {
        Console.WriteLine("[PrintMessage] {0}", msg);
    }
}

//[PrintMessage] Progress Made. 0% complete.
//[PrintMessage] Progress Made. 25% complete.
//[PrintMessage] Progress Made. 50% complete.
//[PrintMessage] Progress Made. 75% complete.