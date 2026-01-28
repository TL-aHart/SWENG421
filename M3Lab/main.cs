using System;
using System.Collections.Generic;
/*
 * File: main.cs
 * Course: SWENG 421
 * Due: 1/29/26
 *
 * Description: main driver for testing
 */
class Program
{
    //temp Employee for testing
    private class TestEmployee : Employee {
        public TestEmployee(string name, int age, string title) : base(name, age, title, 0m) { }
    }

    static void Main()
    {

        //create owner
        Owner craig = new Owner("Craig", 50);

        //create employees (testing, will change to Manager, Accountant, Blacksmith)
        Employee john = new TestEmployee("John", 40, "Manager");
        Employee jane = new TestEmployee("Jane", 35, "Accountant");
        Employee jack = new TestEmployee("Jack", 30, "Blacksmith");

        //owner sends messages
        craig.SendMessage( "Good Job", new List<Employee> { john, jane, jack } );
    }
}
