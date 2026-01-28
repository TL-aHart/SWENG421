/*
 * File: Employee.cs
 * Course: SWENG 421
 * Due: 1/29/26
 *
 * Description: represents an abstract employee with salary information and extends content in Person
 */
public abstract class Employee : Person
{
    private decimal salary;

    protected Employee(string name, int age, string title, decimal startSalary) : base(name, age, title) {
        salary = startSalary;
    }

    public decimal ViewSalary() {
        return salary;
    }

    protected void ChangeSalary(decimal amount) {
        salary += amount;
    }
}
