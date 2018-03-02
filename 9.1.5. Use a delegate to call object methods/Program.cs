using System;

public delegate string DelegateDescription();

public class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public string NameAndAge()
    {
        return (name + " is " + age + " years old");
    }

}

public class Employee
{
    private string name;
    private int number;
    public Employee(string name, int number)
    {
        this.name = name;
        this.number = number;
    }

    public string MakeAndNumber()
    {
        return (name + " is " + number + " mph");
    }
}

class MainClass
{

    public static string  myname()
    {

        return "Geridonus...";
    }



    public delegate string StrGeridondur();
    public static void Main()
    {


      /*  StrGeridondur del = myname;
       // string asa = del();
        StrGeridondur dlen = new StrGeridondur(del);
        string asa = dlen();*/




        Person myPerson = new Person("Price", 32);
        DelegateDescription myDelegateDescription = new DelegateDescription(myPerson.NameAndAge);

        string personDescription = myDelegateDescription();
        Console.WriteLine("personDescription = " + personDescription);

        Employee myEmployee = new Employee("M", 140);

        myDelegateDescription = new DelegateDescription(myEmployee.MakeAndNumber);

        string d = myDelegateDescription();
        Console.WriteLine(d);
    }
}
//personDescription = Price is 32 years old
//M is 140 mph