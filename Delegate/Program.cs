using System;
//9.1.1.	Define a delegate with no return value and no parameters

/// <summary> Using Delegate
///1- A delegate is an object that can refer to a method.
///2- The method referenced by delegate can be called through the delegate.
///3-A delegate in C# is similar to a function pointer in C/C++.
///4-The same delegate can call different methods.
///5- A delegate is declared using the keyword delegate.
///
/// The general form of a delegate declaration:
/// delegate ret-type name(parameter-list);
/// 
/// A delegate can call only methods whose return type and parameter list match those specified by 
/// the delegate's declaration.
/// </summary>

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