using System;
public class HelloWorld
{
    public delegate void MyDelegate(string message);

    public static void Main()
    {
        String message = "Hello Delegates";
        MyDelegate d1 = new MyDelegate(PrintOnce);
        MyDelegate d2 = new MyDelegate(PrintTwice);
        d1(message);
        d2(message);
    }
    public static void PrintOnce(String message)
    {
        Console.WriteLine(message);
    }
    public static void PrintTwice(String message)
    {
        Console.WriteLine("1." + message);
        Console.WriteLine("2." + message);
    }
}