using System;
using System.Windows.Forms;
//9.1.14.	Declare a delegate and assigns a reference to either the WriteLine method or
//the ShowWindowsMessage method to its delegate instance.

delegate void DisplayMessage(string message);

public class TestCustomDelegate
{
    public static void Main()
    {
        DisplayMessage messageTarget;

        if (Environment.GetCommandLineArgs().Length > 1)
            messageTarget = ShowWindowsMessage;
        else
            messageTarget = Console.WriteLine;

        messageTarget("Hello, World!");
    }

    private static void ShowWindowsMessage(string message)
    {
        MessageBox.Show(message);
    }
}