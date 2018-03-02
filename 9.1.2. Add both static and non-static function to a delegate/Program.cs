using System;

//	9.1.2.	Add both static and non-static function to a delegate


delegate void FunctionToCall();

class MyClass
{
    public void nonStaticMethod()
    {
        Console.WriteLine("nonStaticMethod");
    }

    public static void staticMethod()
    {
        Console.WriteLine("staticMethod");
    }
}

class MainClass
{
    static void Main()
    {
        MyClass t = new MyClass();
        FunctionToCall functionDelegate;

      
        functionDelegate = t.nonStaticMethod;
        functionDelegate += MyClass.staticMethod;
        

        functionDelegate += t.nonStaticMethod;
         functionDelegate += MyClass.staticMethod;

        functionDelegate();
    }
}
//nonStaticMethod
//staticMethod
//nonStaticMethod
//staticMethod