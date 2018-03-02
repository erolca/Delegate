using System;
using System.Collections;

public delegate bool HandleKeyword(string key);

public class Parser
{
    Hashtable parseTable;

    public Parser()
    {
        parseTable = new Hashtable();
    }

    public void AddKeywordHandler(string key, HandleKeyword handler)
    {
        parseTable.Add(key, handler);
    }

    public bool ParseKeyword(string key)
    {
        HandleKeyword func = (HandleKeyword)parseTable[key];
        if (func == null)
            return false;

        return func(key);
    }
}

public class HandleHello
{
    public static bool HandleIt(string s)
    {
        Console.WriteLine("HandleHello::HandleIt {0}", s);
        return true;
    }
}

public class HandleGoodbye
{
    public static bool HandleIt(string s)
    {
        Console.WriteLine("HandleGoodbye::HandleIt {0}", s);
        return true;
    }
}

public class HandleWhy
{
    public static bool HandleIt(string s)
    {
        Console.WriteLine("HandleWhy::HandleIt {0}", s);
        return true;
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Parser p = new Parser();

        p.AddKeywordHandler("hello", new HandleKeyword(HandleHello.HandleIt));
        p.AddKeywordHandler("goodbye", new HandleKeyword(HandleGoodbye.HandleIt));
        p.AddKeywordHandler("why", new HandleKeyword(HandleWhy.HandleIt));
        for (int i = 0; i < args.Length; ++i)
            if (p.ParseKeyword(args[i]) == false)
                Console.WriteLine("Unknown keyword {0}", args[i]);
    }
}