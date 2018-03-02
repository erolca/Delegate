using System;
using System.Reflection;
using System.Collections.Generic;

delegate void ComputeDelegate<T>(T instance, Decimal percent);

public class Employee
{
    public Decimal Salary;

    public Employee(Decimal salary)
    {
        this.Salary = salary;
    }

    public void ComputeSalary(Decimal percent)
    {
        Salary *= (1 + percent);
    }
}

public class MainClass
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        employees.Add(new Employee(40));
        employees.Add(new Employee(65));
        employees.Add(new Employee(95));

        MethodInfo mi = typeof(Employee).GetMethod("ComputeSalary", BindingFlags.Public | BindingFlags.Instance);
        ComputeDelegate<Employee> applyRaise = (ComputeDelegate<Employee>)Delegate.CreateDelegate(typeof(ComputeDelegate<Employee>), mi);

        foreach (Employee e in employees)
        {
            applyRaise(e, (Decimal)0.10);
            Console.WriteLine(e.Salary);
        }
    }
}
//44.0
//71.5
//104.5