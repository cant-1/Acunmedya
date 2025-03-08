using System;

namespace odev3;

public class Manager : Employee
{
    public int TeamSize { get; set; }

    public Manager(int id, string name, double salary, string department, int teamSize)
        : base(id, name, salary, department) 
    {
        TeamSize = teamSize;
    }

    public override double CalculateBonus()
    {
        return Salary * 0.20;
    }

    public override string ToString()
    {
        return base.ToString() + $", Takım Büyüklüğü: {TeamSize}, Bonus: {CalculateBonus()}";
    }
}
