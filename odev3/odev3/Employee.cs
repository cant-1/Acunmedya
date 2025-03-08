using System;

namespace odev3;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Department { get; set; }

    public Employee(int id, string name, double salary, string department)
    {
        Id = id;
        Name = name;
        Salary = salary;
        Department = department;
    }

    public virtual double CalculateBonus()
    {
        return 0; 
    }

    public override string ToString()
    {
        return $"ID: {Id}, Ad: {Name}, Maaş: {Salary}, Departman: {Department}";
    }
}
