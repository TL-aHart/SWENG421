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
    private class TestEmployee : Employee {
      //temp, will be replaced later
      public TestEmployee(string name, int age, string title) : base(name, age, title, 0m) { }
    }

    static void Main() {
      Owner craig = new Owner("Craig", 50);
      
      Employee john = new TestEmployee("John", 40, "Manager");
      Employee jane = new TestEmployee("Jane", 35, "Accountant");
      Employee jack = new TestEmployee("Jack", 30, "Blacksmith");
      
      var employees = new List<Employee> { john, jane, jack };
      
      craig.SendMessage("Good Job", employees);
    }
}
