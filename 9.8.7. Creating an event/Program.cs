using System;
public delegate void AgeChangeHandler(int age, object obj,
        ref bool dontdoit);

class Employee
{
    public event AgeChangeHandler AgeChange;
    int fAge;
    public int Age
    {
        set
        {
            Boolean dontdoit = false;
            AgeChange(value, this, ref dontdoit);
            if (!dontdoit)
                fAge = value;
        }
        get
        {
            return fAge;
        }
    }
    public Employee()
    {
        fAge = 0;
    }
}
class MainClass
{
    private static void MyAgeChangeHandler(int age, object obj,
          ref bool dontdoit)
    {
        Console.WriteLine(
           "MyAgeChangeHandler called with age {0} obj.age = {1}",
              age, ((Employee)obj).Age);
        if (age < 0 || age > 99)
            dontdoit = true;
    }

    public static void Main()
    {
        Employee p = new Employee();
        // Set up our handler
        p.AgeChange += new AgeChangeHandler(MyAgeChangeHandler);
        p.Age = 21;
        p.Age = 33;

    }
}