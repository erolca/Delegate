using System;
public class Events
{
    public static void Main()
    {
        Button button = new Button();
        button.OnClick += new Button.EventHandler(Button_Click);
        button.Click();
    }
    public static void Button_Click()
    {
        Console.WriteLine("Button Clicked");
    }
}
public class Button
{
    public delegate void EventHandler();
    public event EventHandler OnClick;
    public void Click()
    {
        OnClick();
    }
}