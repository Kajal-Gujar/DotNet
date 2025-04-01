using System;

// Interface
public interface IDisplayable
{
    void Display();
}

// Base class
public class Person : IDisplayable
{
    private string name;
    private int age;

    // Public constructor
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Implementing interface method
    public void Display()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}


public class Employee : Person
{
    private string department;
    private double salary;

    public Employee(string name, int age, string department, double salary) : base(name, age)
    {
        this.department = department;
        this.salary = salary;
    }

   
    public new void Display()
    {
        base.Display();
        Console.WriteLine($"Department: {department}, Salary: {salary}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Employee employee = new Employee("John Doe", 30, "Engineering", 50000);

        employee.Display(); 
    }
}
