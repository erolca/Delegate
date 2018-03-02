using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    delegate void MessagePrintDelegate(string msg);

    /*******************Main*******************/
    static void Main(string[] args)
    {


        MessagePrintDelegate mpd2 = delegate (string msg)
        {
            Console.WriteLine("[Anonymous] {0}", msg);
        };
        LongRunningMethod(mpd2);

    }/*--------------End Of Main--------------*/


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