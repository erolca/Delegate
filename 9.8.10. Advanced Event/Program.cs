using System;
using System.Collections.Generic;
using System.Text;

delegate void NameChangedDelegate(string name, string newValue);

class Program
{
    static void Main(string[] args)
    {
        Employee c = new Employee();
        Subscriber s1 = new Subscriber(c, "subscriber-A");
        Subscriber s2 = new Subscriber(c, "subscriber-B");
        Subscriber s3 = new Subscriber(c, "subscriber-C");

        c.FirstName = "F";

        s2.Unsubscribe();

        c.FirstName = "A";
    }
}
class Subscriber
{
    public string SubscriberID = "new subscriber";
    public Employee myEmployee = null;
    public NameChangedDelegate ncDel = null;

    public Subscriber(Employee c, string subId)
    {
        SubscriberID = subId;
        ncDel = new NameChangedDelegate(myEmployee_OnNameChanged);
        myEmployee = c;
        myEmployee.OnNameChanged += ncDel;
    }

    void myEmployee_OnNameChanged(string name, string newValue)
    {
        Console.WriteLine("[{0}] Employee {1} changed to {2}.", SubscriberID,
            name, newValue);
    }

    public void Unsubscribe()
    {
        myEmployee.OnNameChanged -= ncDel;
    }
}

class Employee
{
    private string firstName;
    private event NameChangedDelegate onNameChange;

    public event NameChangedDelegate OnNameChanged
    {
        add
        {
            onNameChange += value;
            if (value.Target is Subscriber)
            {
                Console.WriteLine("Subscriber '{0}' just subscribed to OnNameChanged.",
                    ((Subscriber)value.Target).SubscriberID);
            }
        }
        remove
        {
            onNameChange -= value;
            if (value.Target is Subscriber)
            {
                Console.WriteLine("Subscriber '{0}' just un-subscribed from OnNameChanged.",
                    ((Subscriber)value.Target).SubscriberID);
            }
        }
    }

    public string FirstName
    {
        get { return firstName; }
        set
        {
            firstName = value;
            onNameChange("firstname", value);
        }
    }
}