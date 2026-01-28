/*
 * File: Person.cs
 * Course: SWENG 421
 * Due: 1/29/26
 *
 * Description: defines the abstract base class for all individuals in the company
 */
public abstract class Person
{
    private string name;
    private int age;
    private string title;

    protected Person(string name, int age, string title) {
        this.name = name;
        this.age = age;
        this.title = title;
    }

    public string Name => name;
    public string Title => title;
}
